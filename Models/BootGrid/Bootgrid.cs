using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapi.Data;

namespace webapi.Models.BootGrid
{
    public class Bootgrid_radusage
    {
        public int current { get; set; }
        public int rowCount { get; set; }
        public List<Bootgrid_radiusentry_summary> rows { get; set; }
        public int total { get; set; }
    }
    
    public class Bootgrid_radiusentry
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int MonthIn { get; set; }
        public long? Upload { get; set; }
        public long? Download { get; set; }
    }
    public class Bootgrid_radiusentry_summary
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Download01 { get; set; }
        public string Download02 { get; set; }
        public string Download03 { get; set; }
        public string Download04 { get; set; }
        public string Download05 { get; set; }
        public string Download06 { get; set; }
        public string Download07 { get; set; }
        public string Download08 { get; set; }
        public string Download09 { get; set; }
        public string Download10 { get; set; }
        public string Download11 { get; set; }
        public string Download12 { get; set; }
        public long? down1 { get; set; }
        public long? down2 { get; set; }
        public long? down3 { get; set; }
        public long? down4 { get; set; }
        public long? down5 { get; set; }
        public long? down6 { get; set; }
        public long? down7 { get; set; }
        public long? down8 { get; set; }
        public long? down9 { get; set; }
        public long? down10 { get; set; }
        public long? down11 { get; set; }
        public long? down12 { get; set; }
    }
    public class Bootgrid_Sort
    {
        public string Username { get; set; }
        public string Download01 { get; set; }
        public string Download02 { get; set; }
        public string Download03 { get; set; }
        public string Download04 { get; set; }
        public string Download05 { get; set; }
        public string Download06 { get; set; }
        public string Download07 { get; set; }
        public string Download08 { get; set; }
        public string Download09 { get; set; }
        public string Download10 { get; set; }
        public string Download11 { get; set; }
        public string Download12 { get; set; }
    }

    public class Bootgrid_invoicesummary
    {
        public int current { get; set; }
        public int rowCount { get; set; }
        public List<bootgridinvoiceSummary_list> rows { get; set; }
        public int total { get; set; }
    }
    public class bootgridinvoiceSummary_list
    {

        public string Name { get; set; }
        public double? Jan { get; set; }
        public double? Feb { get; set; }
        public double? Mar { get; set; }
        public double? Apr { get; set; }
        public double? May { get; set; }
        public double? Jun { get; set; }
        public double? Jul { get; set; }
        public double? Aug { get; set; }
        public double? Sep { get; set; }
        public double? Oct { get; set; }
        public double? Nov { get; set; }
        public double? Dec { get; set; }
        public double? Tot { get; set; }
    }
}