using System.ComponentModel.DataAnnotations;
public enum ContactTypeEnum
{
    [Display(Name ="پیامک")]
    SMS=1,
    [Display(Name = "پست الکترونیکی")]
    Email=2,
    
}

