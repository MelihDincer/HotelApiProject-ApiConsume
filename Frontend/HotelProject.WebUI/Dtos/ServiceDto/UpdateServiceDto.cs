﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string? ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığını  giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Hizmet açıklaması  giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet açıklaması en fazla 100 karakter olabilir")]
        public string? Description { get; set; }
    }
}
