using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Ip.Firewall;
using tik4net.Objects.Ppp;
using webapi.Data;

namespace webapi.Helpers
{
    public class MikrotikHelper
    {
        public static bool Mikrotik()

        {

            using (ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api)) // Use TikConnectionType.Api for mikrotikversion prior v6.45
            {
                connection.Open("10.19.20.1", "OrionAdmin", "Frank1e2015");
                ITikCommand cmd = connection.CreateCommand("/system/identity/print");
                var identity = cmd.ExecuteScalar();
                Console.WriteLine("Identity: {0}", identity);
                var logs = connection.LoadList<Log>();
                foreach (Log log in logs)
                {
                    Console.WriteLine("{0}[{1}]: {2}", log.Time, log.Topics, log.Message);
                }
                var firewallFilter = new FirewallFilter()
                {
                    Chain = FirewallFilter.ChainType.Forward,
                    Action = FirewallFilter.ActionType.Accept,
                };
                connection.Save(firewallFilter);
                ITikCommand torchCmd = connection.CreateCommand("/tool/torch",
                   connection.CreateParameter("interface", "ether1"),
                   connection.CreateParameter("port", "any"),
                   connection.CreateParameter("src-address", "0.0.0.0/0"),
                   connection.CreateParameter("dst-address", "0.0.0.0/0"));

                torchCmd.ExecuteAsync(response =>
                      {
                          Console.WriteLine("Row: " + response.GetResponseField("tx"));
                      });
                Console.WriteLine("Press ENTER");
                Console.ReadLine();
                torchCmd.Cancel();
                return true;
            }
        }
        public static bool UpdateRadius()
        {
            radiusEntities redb = new radiusEntities();
            OrionAdminEntities oadb = new OrionAdminEntities();
            var aa = (from z in redb.radaccts
                      where z.acctstarttime.Value.Year == 2020 && z.acctstarttime.Value.Month < 4
                      orderby z.acctstarttime
                      select z);
            foreach (radacct ra in aa)
            {
                if (ra.acctstoptime != null)
                {
                    if (ra.acctstarttime.Value.Day == ra.acctstoptime.Value.Day)
                    {
                        radiusUsage ru = new radiusUsage();
                        ru.date = ra.acctstarttime;
                        ru.upload = ra.acctinputoctets / 8;
                        ru.download = ra.acctoutputoctets / 8;
                        ru.username = ra.username;
                        oadb.radiusUsages.Add(ru);
                        oadb.SaveChanges();
                    }
                    else
                    {
                        long totaldays = Convert.ToInt64((ra.acctstoptime - ra.acctstarttime).Value.TotalDays + 1);
                        for (int i = 0; i < totaldays; i++)
                        {
                            radiusUsage ru = new radiusUsage();
                            ru.date = ra.acctstarttime.Value.AddDays(i);
                            ru.upload = (ra.acctinputoctets / 8) / totaldays;
                            ru.download = (ra.acctoutputoctets / 8) / totaldays;
                            ru.username = ra.username;
                            oadb.radiusUsages.Add(ru);
                            oadb.SaveChanges();
                        }
                    }
                }
            }


            return true;
        }
        public static bool UpdateSecret()
        {
            using (ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api)) // Use TikConnectionType.Api for mikrotikversion prior v6.45
            {
                connection.Open("10.19.60.1", "OrionAdmin", "Frank1e2015");

                radiusEntities db = new radiusEntities();
                List<RadiusEntry> radiusentries = db.RadiusEntries.ToList();
                foreach (RadiusEntry re in radiusentries)
                {
                    ITikCommand cmd = connection.CreateCommand("/ppp/secret/add",
                     connection.CreateParameter("name", re.username),
                    connection.CreateParameter("password", re.value),
                    connection.CreateParameter("profile", re.groupname));
                    cmd.ExecuteAsync(response =>
                        {
                            // Console.WriteLine("Row: " + response.GetResponseField("tx"));
                        });

                    cmd.Cancel();
                }
                return true;
            }
        }

        public static bool suspendpppoeuser(string pppoeuser)
        {
            using (ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api)) // Use TikConnectionType.Api for mikrotikversion prior v6.45
            {
                connection.Open("10.19.10.1", "OrionAdmin", "Frank1e2015");


                var pppoeactive = connection.LoadList<PppActive>();
                foreach (PppActive pppa in pppoeactive)
                {
                    string ipaddress = "";
                    if (pppa.Name == pppoeuser)
                    {
                        ipaddress = pppa.Address;
                    }
                    if (ipaddress != "")
                    {
                        ITikCommand cmd = connection.CreateCommand("/ip/firewall/address-list/add",
                             connection.CreateParameter("list", "unmssuspend"),
                            connection.CreateParameter("address", ipaddress),
                            connection.CreateParameter("comment", "suspend"));
                                cmd.ExecuteAsync(response =>
                        {
                            // Console.WriteLine("Row: " + response.GetResponseField("tx"));
                        });

                        cmd.Cancel();
                    }
                }

                connection.Close();
            }
            return true;
        }
    }
}

