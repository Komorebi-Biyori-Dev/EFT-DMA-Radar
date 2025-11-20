using System.Windows;

namespace LoneEftDmaRadar.UI.ESP
{
    public static class ESPManager
    {
        private static ESPWindow _espWindow;
        private static bool _isInitialized = false;

        public static void Initialize()
        {
            if (_isInitialized && _espWindow != null) return;

            _espWindow = new ESPWindow();
            _espWindow.Closed += (s, e) => 
            { 
                _espWindow = null; 
                _isInitialized = false;
                ESPWindow.ShowESP = false; // Sync state
            };
            // _espWindow.Show(); // Don't show automatically on init
            _isInitialized = true;
        }

        public static void ToggleESP()
        {
            if (!_isInitialized || _espWindow == null) Initialize();
            
            ESPWindow.ShowESP = !ESPWindow.ShowESP;
            _espWindow?.RefreshESP();
            if (ESPWindow.ShowESP) _espWindow?.Show();
            else _espWindow?.Hide();
        }

        public static void ShowESP()
        {
            if (!_isInitialized || _espWindow == null) Initialize();
            
            ESPWindow.ShowESP = true;
            _espWindow?.RefreshESP();
            _espWindow?.Show();
        }

        public static void StartESP()
        {
            if (!_isInitialized || _espWindow == null) Initialize();
            
            ESPWindow.ShowESP = true;
            _espWindow?.Show();
            // Force Fullscreen
            if (_espWindow.WindowStyle != WindowStyle.None)
            {
                _espWindow.ToggleFullscreen();
            }
            else
            {
                _espWindow.ApplyResolutionOverride();
            }
        }

        public static void HideESP()
        {
            ESPWindow.ShowESP = false;
            _espWindow?.RefreshESP();
            _espWindow?.Hide();
        }

        public static void ToggleFullscreen()
        {
            if (!_isInitialized) Initialize();
            _espWindow?.ToggleFullscreen();
        }
        
        public static void CloseESP()
        {
            _espWindow?.Close();
            _espWindow = null;
            _isInitialized = false;
        }

        public static void ApplyResolutionOverride()
        {
            if (!_isInitialized || _espWindow is null) return;
            _espWindow.ApplyResolutionOverride();
        }

        public static bool IsInitialized => _isInitialized;
    }
}