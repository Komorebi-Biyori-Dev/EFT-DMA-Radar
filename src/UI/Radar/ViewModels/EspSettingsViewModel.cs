using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LoneEftDmaRadar.UI.ESP;
using LoneEftDmaRadar.UI.Misc;

namespace LoneEftDmaRadar.UI.Radar.ViewModels
{
    public class EspSettingsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public EspSettingsViewModel()
        {
            ToggleEspCommand = new SimpleCommand(() =>
            {
                ESPManager.ToggleESP();
            });
            
            StartEspCommand = new SimpleCommand(() =>
            {
                ESPManager.StartESP();
            });
        }

        public ICommand ToggleEspCommand { get; }
        public ICommand StartEspCommand { get; }

        public bool ShowESP
        {
            get => App.Config.UI.ShowESP;
            set
            {
                if (App.Config.UI.ShowESP != value)
                {
                    App.Config.UI.ShowESP = value;
                    if (value) ESPManager.ShowESP(); else ESPManager.HideESP();
                    OnPropertyChanged();
                }
            }
        }

        public bool EspPlayerSkeletons
        {
            get => App.Config.UI.EspPlayerSkeletons;
            set
            {
                if (App.Config.UI.EspPlayerSkeletons != value)
                {
                    App.Config.UI.EspPlayerSkeletons = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspPlayerBoxes
        {
            get => App.Config.UI.EspPlayerBoxes;
            set
            {
                if (App.Config.UI.EspPlayerBoxes != value)
                {
                    App.Config.UI.EspPlayerBoxes = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspPlayerNames
        {
            get => App.Config.UI.EspPlayerNames;
            set
            {
                if (App.Config.UI.EspPlayerNames != value)
                {
                    App.Config.UI.EspPlayerNames = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspAISkeletons
        {
            get => App.Config.UI.EspAISkeletons;
            set
            {
                if (App.Config.UI.EspAISkeletons != value)
                {
                    App.Config.UI.EspAISkeletons = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspAIBoxes
        {
            get => App.Config.UI.EspAIBoxes;
            set
            {
                if (App.Config.UI.EspAIBoxes != value)
                {
                    App.Config.UI.EspAIBoxes = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspAINames
        {
            get => App.Config.UI.EspAINames;
            set
            {
                if (App.Config.UI.EspAINames != value)
                {
                    App.Config.UI.EspAINames = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public bool EspLoot
        {
            get => App.Config.UI.EspLoot;
            set
            {
                if (App.Config.UI.EspLoot != value)
                {
                    App.Config.UI.EspLoot = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspLootPrice
        {
            get => App.Config.UI.EspLootPrice;
            set
            {
                if (App.Config.UI.EspLootPrice != value)
                {
                    App.Config.UI.EspLootPrice = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspLootConeEnabled
        {
            get => App.Config.UI.EspLootConeEnabled;
            set
            {
                if (App.Config.UI.EspLootConeEnabled != value)
                {
                    App.Config.UI.EspLootConeEnabled = value;
                    OnPropertyChanged();
                }
            }
        }

        public float EspLootConeAngle
        {
            get => App.Config.UI.EspLootConeAngle;
            set
            {
                if (Math.Abs(App.Config.UI.EspLootConeAngle - value) > float.Epsilon)
                {
                    App.Config.UI.EspLootConeAngle = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspExfils
        {
            get => App.Config.UI.EspExfils;
            set
            {
                if (App.Config.UI.EspExfils != value)
                {
                    App.Config.UI.EspExfils = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EspCrosshair
        {
            get => App.Config.UI.EspCrosshair;
            set
            {
                if (App.Config.UI.EspCrosshair != value)
                {
                    App.Config.UI.EspCrosshair = value;
                    OnPropertyChanged();
                }
            }
        }

        public float EspCrosshairLength
        {
            get => App.Config.UI.EspCrosshairLength;
            set
            {
                if (Math.Abs(App.Config.UI.EspCrosshairLength - value) > float.Epsilon)
                {
                    App.Config.UI.EspCrosshairLength = value;
                    OnPropertyChanged();
                }
            }
        }

        public int EspScreenWidth
        {
            get => App.Config.UI.EspScreenWidth;
            set
            {
                if (App.Config.UI.EspScreenWidth != value)
                {
                    App.Config.UI.EspScreenWidth = value;
                    ESPManager.ApplyResolutionOverride();
                    OnPropertyChanged();
                }
            }
        }

        public int EspScreenHeight
        {
            get => App.Config.UI.EspScreenHeight;
            set
            {
                if (App.Config.UI.EspScreenHeight != value)
                {
                    App.Config.UI.EspScreenHeight = value;
                    ESPManager.ApplyResolutionOverride();
                    OnPropertyChanged();
                }
            }
        }

        public float FOV
        {
            get => App.Config.UI.FOV;
            set
            {
                if (App.Config.UI.FOV != value)
                {
                    App.Config.UI.FOV = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

