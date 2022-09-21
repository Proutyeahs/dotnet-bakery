using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DotnetBakery.Models
{
    public class Bread 
    {
        public int id {get; set;}
        public string name {get; set;}
        public string description {get; set;}
        public int count {get; set;}

        // relation to the baker
        [ForeignKey("bakedBy")]
        public int bakedById {get; set;}

        // the actual baker object from DB
        public Baker bakedBy {get; set;}
    }
}
