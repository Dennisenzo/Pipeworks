using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Denga.Pipeworks.SiteSettings
{
    public class SiteSettingsGroupSiteSetting
    {
        public int SettingId { get; set; }
        public int SettingsGroupId { get; set; }
        [ForeignKey("SettingsGroupId")]
        public SiteSettingsGroup SettingsGroup { get; set; }
        [ForeignKey("SettingId")]
        public SiteSetting Setting { get; set; }
    }
}