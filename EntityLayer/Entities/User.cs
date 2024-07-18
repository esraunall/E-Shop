﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olamalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olamalıdır.")]
        public string Surname { get; set; }

        //[Required(ErrorMessage = "Boş Geçilemez")]
        //[Display(Name = "E-Posta")]
        //[StringLength(50, ErrorMessage = "Max 50 karakter olamalıdır.")]
        //[EmailAddress(ErrorMessage = "e-mail formatı şeklinde giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olamalıdır.")]
        public string Username { get; set; }

        //[Required(ErrorMessage = "Boş Geçilemez")]
        //[Display(Name = "Şifre")]
        //[DataType(DataType.Password)]
        //[StringLength(10, ErrorMessage = "Max 10 karakter olamalıdır.")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Boş Geçilemez")]
        //[Display(Name = "Şifre tekrar")]
        //[StringLength(10, ErrorMessage = "Max 10 karakter olamalıdır.")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "şifreler uyuşmuyor")]
        public string RePassword { get; set; }

        [StringLength(10, ErrorMessage = "Max 10 karakter olamalıdır.")]
        public string Role { get; set; }
    }
}
