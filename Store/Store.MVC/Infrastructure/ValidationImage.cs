using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.MVC.Infrastructure
{
    public class ValidationImage : ValidationAttribute
    {
        public override bool IsValid(object uploadFile)
        {
            var file = uploadFile as String;
            var supportedTypes = new[] { "jpg", "jpeg", "png" };
            var fileExt = System.IO.Path.GetExtension(file).Substring(1);
            if(!supportedTypes.Contains(fileExt))
            {
                return false;
            }         
            return true;
        }
    }
}