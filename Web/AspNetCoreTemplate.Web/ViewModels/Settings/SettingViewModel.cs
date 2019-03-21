namespace ERP.Web.ViewModels.Settings
{
    using ERP.Data.Models;
    using ERP.Services.Mapping;

    public class SettingViewModel : IMapFrom<Setting>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
