using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System;
using Skoruba.IdentityServer4.Admin.EntityFramework.Shared.Entities.Identity;

namespace Skoruba.IdentityServer4.Admin.EntityFramework.Shared.Entities.Nong
{
    public class NongApplicationUser 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; } = 0;
        [Required]
        [StringLength(20)]
        public string UserCode { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string Province { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string City { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string Town { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string County { get; set; } = string.Empty;
        [Required]
        public double Longitude { get; set; } = 0.0D;
        [Required]
        public double Latitude { get; set; } = 0.0D;
        [Required]
        [StringLength(20)]
        public string Mobile { get; set; } = string.Empty;
        [JsonIgnore]
        [Required]
        [StringLength(200)]
        public string Password { get; set; } = string.Empty;
        [JsonIgnore]
        [Required]
        [StringLength(20)]
        public string Salt { get; set; } = string.Empty;
        [Required]
        public int Tag { get; set; } = 0;
        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
