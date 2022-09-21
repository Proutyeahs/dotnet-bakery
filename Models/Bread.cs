using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DotnetBakery.Models
{

    public enum BreadType
    {
        Sourdough,           // 0
        Rye,                 // 1 etc.. v
        Pumpernickel,
        French,
        Tortilla,
        HoneyWheat,
        Pretzel,
        Boule,
    }
    public class Bread 
    {
        public int id {get; set;}
        public string name {get; set;}
        public string description {get; set;}

        // need a bread type
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BreadType type {get; set;}
        
        public int count {get; set;}

        // relation to the baker
        [ForeignKey("bakedBy")]
        public int bakedById {get; set;}

        // the actual baker object from DB
        public Baker bakedBy {get; set;}
    }
}
