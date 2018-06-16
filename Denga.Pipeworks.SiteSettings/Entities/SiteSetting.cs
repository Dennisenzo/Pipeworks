using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Denga.Pipeworks.SiteSettings
{
    public class SiteSetting
    {
        [Key]
        public int Id { get; set; }
        public List<SiteSettingsGroupSiteSetting> SettingsGroupSettings { get; set; }
        public string Key { get; set; }
        public virtual string Value { get; set; }
    }
}