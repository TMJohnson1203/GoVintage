//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoVintage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BottomsTable
    {
        public int BottomsID { get; set; }
        [Display(Name = "Name")]
        public string BottomsName { get; set; }
        [Display(Name = "Photo")]
        public string BottomsPhoto { get; set; }
        [Display(Name = "Type")]
        public string BottomsType { get; set; }
        [Display(Name = "Color")]
        public string BottomsColor { get; set; }
        [Display(Name = "Season")]
        public string BottomsSeason { get; set; }
        [Display(Name = "Occasion")]
        public string BottomsOccasion { get; set; }
    }
}
