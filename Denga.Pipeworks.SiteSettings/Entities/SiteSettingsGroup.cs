using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Denga.Pipeworks.SiteSettings
{
    public class SiteSettingsGroup
    {
        [Key]
        public int Id { get; set; }
        public List<SiteSettingsGroupSiteSetting> SettingsGroupSettings { get; set; }
    }
}