using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace ShoppingCarts.Helpers
{
    public static class Settings
    {
        private static ISettings Setting
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static bool ItemStatus1
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus1", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus1", value);
            }
        }

        public static bool ItemStatus2
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus2", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus2", value);
            }
        }

        public static bool ItemStatus3
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus3", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus3", value);
            }
        }

        public static bool ItemStatus4
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus4", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus4", value);
            }
        }

        public static bool ItemStatus5
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus5", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus5", value);
            }
        }

        public static bool ItemStatus6
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus6", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus6", value);
            }
        }

        public static bool ItemStatus7
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus7", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus7", value);
            }
        }

        public static bool ItemStatus8
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus8", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus8", value);
            }
        }

        public static bool ItemStatus9
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus9", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus9", value);
            }
        }

        public static bool ItemStatus10
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus10", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus10", value);
            }
        }

        public static bool ItemStatus11
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus11", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus11", value);
            }
        }

        public static bool ItemStatus12
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus12", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus12", value);
            }
        }

        public static bool ItemStatus13
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus13", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus13", value);
            }
        }

        public static bool ItemStatus14
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus14", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus14", value);
            }
        }

        public static bool ItemStatus15
        {
            get
            {
                return Setting.GetValueOrDefault("ItemStatus15", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemStatus15", value);
            }
        }

        public static bool ItemCustomStatus1
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus1", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus1", value);
            }
        }

        public static bool ItemCustomStatus2
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus2", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus2", value);
            }
        }

        public static bool ItemCustomStatus3
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus3", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus3", value);
            }
        }

        public static bool ItemCustomStatus4
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus4", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus4", value);
            }
        }

        public static bool ItemCustomStatus5
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus5", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus5", value);
            }
        }

        public static bool ItemCustomStatus6
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus6", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus6", value);
            }
        }

        public static bool ItemCustomStatus7
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus7", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus7", value);
            }
        }

        public static bool ItemCustomStatus8
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus8", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus8", value);
            }
        }

        public static bool ItemCustomStatus9
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus9", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus9", value);
            }
        }

        public static bool ItemCustomStatus10
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus10", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus10", value);
            }
        }

        public static bool ItemCustomStatus11
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus11", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus11", value);
            }
        }

        public static bool ItemCustomStatus12
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus12", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus12", value);
            }
        }

        public static bool ItemCustomStatus13
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus13", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus13", value);
            }
        }

        public static bool ItemCustomStatus14
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus14", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus14", value);
            }
        }

        public static bool ItemCustomStatus15
        {
            get
            {
                return Setting.GetValueOrDefault("ItemCustomStatus15", false);
            }
            set
            {
                Setting.AddOrUpdateValue("ItemCustomStatus15", value);
            }
        }
    }
}