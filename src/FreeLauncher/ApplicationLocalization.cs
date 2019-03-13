namespace FreeLauncher
{
    public class ApplicationLocalization
    {
        public string Name { get; set; } = "Turkce";
        public string LanguageTag { get; set; } = "tr_TR";
        public string Authors { get; set; } = "KaptanBarba";

        #region LauncherForm

        #region Tabs

        public string NewsTabText { get; set; } = "HABERLER";
        public string ConsoleTabText { get; set; } = "KONSOL";
        public string ManageVersionsTabText { get; set; } = "VERSIYON";
        public string ManageProfilesTabText { get; set; } = "PROFIL";
        public string AboutTabText { get; set; } = "AYARLAR";
        public string LicensesTabText { get; set; } = "LISANSLAR";
        public string SettingsTabText { get; set; } = "AYARLAR";

        #endregion

        #region Main Controls

        public string LaunchButtonText { get; set; } = "Oyna";
        public string AddProfileButtonText { get; set; } = "Profil ekle";
        public string EditProfileButtonText { get; set; } = "Profili Düzenle";
        public string SetToClipboardButtonText { get; set; } = "Panoya kopyala";

        #endregion

        #region Build Managment Tab

        public string VersionHeader { get; set; } = "Versiyon";
        public string TypeHeader { get; set; } = "Tip";
        public string ReleaseDateHeader { get; set; } = "Çıkış tarihi";
        public string LastUpdatedHeader { get; set; } = "Son güncelleme";
        public string AssetsIndexHeader { get; set; } = "Kaynak dizini";
        public string DependencyHeader { get; set; } = "Bağlıdır";
        
        public string Restore { get; set; } = "Yeniden";
        public string OpenLocation { get; set; } = "Konumu görüntüle";
        public string DeleteVersion { get; set; } = "Montajı kaldır";
        public string DeleteConfirmationTitle { get; set; } = "Silme Onayı";
        public string DeleteConfirmationText { get; set; } = "'{0}' derlemesini kaldırmak istediğinizden emin misiniz?";

        #endregion

        #region Profile Managment Tab

        public string MoveUp { get; set; } = "Yukarı";
        public string MoveDown { get; set; } = "Aşağı";
        #endregion

        #region About Tab

        public string DevInfo { get; set; } = "KaptanBarba tarafından geliştirildi";
        public string GratitudesText { get; set; } = "Teşekkürler";
        public string GratitudesDescription { get; set; } = "Başlatıcı/Launcher hakkında bilgilendirme.";
        public string PartnersText { get; set; } = "Ortaklar";
        public string MCofflineDescription { get; set; } = "MCTürk - oyuncular için en iyi Türk sunucusu!";

        public string CopyrightInfo { get; set; } =
            "\"Minecraft\" Mojang Synergies AB'nin bir ticari markasıdır. Tüm hakları saklıdır.\nMojang Synergies AB, Microsoft Studios'un bir alt kuruluşudur.";

        #endregion

        #region Settings Tab

        public string MainSettingsTitle { get; set; } = "Ayarlar";
        public string CheckUpdatesCheckBox { get; set; } = "Başlatıcı güncellemelerini kontrol et";
        public string SkipAssetsDownload { get; set; } = "Kaynak indirmelerini atla";
        public string EnableMinecraftLoggingText { get; set; } = "Konsoldaki oyun günlüğünü görüntüle";
        public string LoggerSettingsTitle { get; set; } = "Günlük kaydı";

        public string CloseGameOutputText { get; set; } =
            "Hata yoksa sekmeleri otomatik olarak kapat";

        #endregion

        public string Launch { get; set; } = "Başlat";
        public string Delete { get; set; } = "Silmek";
        public string ReadyToLaunch { get; set; } = "{0} derlemesini çalıştırmaya hazır";
        public string ReadyToDownload { get; set; } = "{0} grubunu yüklemeye hazır";
        public string EditingProfileTitle { get; set; } = "Profil düzenleme";
        public string ProfileAlreadyExistsErrorText { get; set; } = "Bu profil listede zaten var!";
        public string ProfileDeleteConfirmationText { get; set; } = "'{0}' profilini silmek istediğinize emin misiniz?";
        public string AddingProfileTitle { get; set; } = "Profil ekle";
        public string CheckingVersionAvailability { get; set; } = "'{0}' grubunun uygunluğunun kontrol edilmesi";
        public string CheckingLibraries { get; set; } = "Kütüphane kontrolü devam ediyor";
        public string GameOutput { get; set; } = "OYUN ÇALIŞIYOR";
        public string KillProcess { get; set; } = "Oyunu Durdur";
        public string Independent { get; set; } = "Bağımsız";
        public string InvalidSessionMessage { get; set; } = "Oturum Simgesi kullanımdan kaldırıldı. Lütfen hesabınıza tekrar giriş yapın.";
        public string SomeFilesMissingMessage { get; set; } = "Bu başlatıcıyı ilk defa kullanıyor gibisin.\nNe yazık ki, gerekli bazı dosyalar eksiktir ve İnternet bağlantısı olmadan indirilemezler.\nLütfen ağ ayarlarınızı kontrol edin ve başlatıcıyı yeniden başlatın.";

        #endregion

        #region ProfileForm

        #region GroupBoxes

        public string MainProfileSettingsGroup { get; set; } = "Genel profil ayarları";
        public string VersionSettingsGroup { get; set; } = "Sürüm seçimi";
        public string JavaSettingsGroup { get; set; } = "Java ayarları";

        #endregion

        #region Main Settings

        public string ProfileName { get; set; } = "Profil Adı:";
        public string WorkingDirectory { get; set; } = "Çalışma dizini:";
        public string WindowResolution { get; set; } = "Pencere çözünürlüğü:";
        public string ActionAfterLaunch { get; set; } = "Oyun açıldıktan sonra:";
        public string KeepLauncherOpen { get; set; } = "Başlatıcıyı açık bırak";
        public string HideLauncher { get; set; } = "Başlatıcıyı Gizle";
        public string CloseLauncher { get; set; } = "Başlatıcıyı kapat";
        public string Autoconnect { get; set; } = "Otomatik bağlantı:";

        #endregion

        #region Version Selection

        public string Snapshots { get; set; } = "Deneysel yapıları görüntüle (\"snapshots\")";
        public string Beta { get; set; } = "\"Beta\" montajlarını görüntüle (2011-2012)";
        public string Alpha { get; set; } = "\"Alpha\" ekranını gösterir (2011 yılına kadar)";
        public string Other { get; set; } = "Üçüncü taraf yapılarını göster(Forge, LiteLoader, etc.)";
        public string UseLatestVersion { get; set; } = "En son yapıyı kullan '{0}'";

        #endregion

        #region Java Options

        public string JavaExecutable { get; set; } = "Java:";
        public string JavaFlags { get; set; } = "JVM bayrakları:";

        #endregion

        public string OpenDirectory { get; set; } = "Dosya Konumu";

        public string JavaDetectionFailed { get; set; } =
            "Java'nın yolu belirlenemedi! Lütfen çalıştırılabilir dosyanın yolunu manuel olarak belirtin.";

        #endregion

        #region UsersForm

        public string AddNewUserBox { get; set; } = "Yeni kullanıcı ekle";
        public string Nickname { get; set; } = "Kullanıcı adı:";
        public string LicenseQuestion { get; set; } = "Lisanslı bir hesabınız var mı?";
        public string Password { get; set; } = "Şifre:";
        public string AddNewUserButton { get; set; } = "Yeni kullanıcı ekle";
        public string RemoveSelectedUser { get; set; } = "Seçilen kullanıcıyı sil";
        public string IncorrectLoginOrPassword { get; set; } = "Kullanıcı adı veya şifre yanlış girildi!";
        public string PleaseWait { get; set; } = "Lütfen bekle";

        #endregion

        #region UpdateForm

        public string GoToGitHub { get; set; } = "Github'a git";
        public string SupportDeveloper { get; set; } = "Destek geliştirici";

        #endregion

        public string Error { get; set; } = "Hata";
        public string Cancel { get; set; } = "Iptal";
        public string Close { get; set; } = "Kapat";
        public string Save { get; set; } = "Kaydet";
    }
}
