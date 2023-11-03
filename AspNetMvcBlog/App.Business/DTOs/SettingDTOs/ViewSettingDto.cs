﻿using System.ComponentModel;

namespace App.Business.DTOs.Setting
{
    public class ViewSettingDto
    {
        public int Id { get; set; }
        [DisplayName("Karanlık Mod")]
        public bool DarkMode { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
    }
}