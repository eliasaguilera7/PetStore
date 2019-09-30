using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class PetFood
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual Decimal Price { get; set; }
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }

        [Display(Name = "Nutritional  Information")]
        public virtual String NutritionalInformation { get; set; }
        public virtual Double Weight { get; set; }
        public virtual String Brand { get; set; }

        [Display(Name="Type of Animal Food is for")]
        public virtual String TypeOfAnimalFoodIsFor { get; set; }
        //This is a comment lets see if now somethig changes . ANd now another change!!jhjhjh

    }
}