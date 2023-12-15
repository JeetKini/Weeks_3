using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;



namespace Revision_WebApp.Models
{
    public class Employee
    {
        [Display(Name = "Please enter your Id")]
        public int Id { get; set; }
       

        [Display(Name = "Please Enter your Name")]
       
        public string Name { get; set; }

        [Display(Name = "Please Enter your Name")]
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

       
        
        

        
        public string Address { get; set; }
    }
}