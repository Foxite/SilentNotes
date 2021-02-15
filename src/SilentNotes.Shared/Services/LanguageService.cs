﻿// Copyright © 2018 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Collections.Generic;

namespace SilentNotes.Services
{
    /// <summary>
    /// App specific implementation of the <see cref="ILanguageService"/> interface.
    /// </summary>
    public class LanguageService : LanguageServiceBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageService"/> class.
        /// </summary>
        /// <param name="languageCode">Language code.</param>
        public LanguageService(string languageCode)
            : base(languageCode)
        {
        }

        private void LoadEnglishResources(Dictionary<string, string> resources)
        {
            resources["ok"] = "OK";
            resources["cancel"] = "Cancel";
            resources["back"] = "Back";
            resources["continue"] = "Continue";
            resources["search"] = "Search";

            resources["today"] = "today";
            resources["yesterday"] = "yesterday";
            resources["days_ago"] = "{0} days ago";
            resources["weeks_ago"] = "{0} weeks ago";
            resources["months_ago"] = "{0} month ago";
            resources["years_ago"] = "{0} years ago";
            resources["modified_at"] = "Modified {0}";

            resources["error_loading_repository"] = "Could not read the notes. The application was stopped, to avoid further damage of already existing notes.";
            resources["welcome_note"] = "<h1>Welcome 💛</h1><p>SilentNotes respects your privacy. It doesn't collect personal data, runs free of adds and is open source.</p>";
            resources["welcome_note_2"] = "<h1>Ordering notes</h1><p>Drag the double-arrow icon on a note to change the order.</p>";
            resources["welcome_note_3"] = "<h1>Password protection</h1><p>Open the safe and use the lock icon to protect a note.</p>";

            resources["note_create_new"] = "Create new note";
            resources["note_undelete"] = "Restore note";
            resources["note_title"] = "Title";
            resources["note_content"] = "Text";
            resources["note_left_key"] = "Left arrow key";
            resources["note_right_key"] = "Right arrow key";
            resources["note_colors"] = "Choose note color";
            resources["note_bold"] = "Bold";
            resources["note_italic"] = "Italic";
            resources["note_underline"] = "Underline";
            resources["note_strike"] = "Strike";
            resources["note_list_ordered"] = "Numbered list";
            resources["note_list_unordered"] = "Bulleted list";
            resources["note_code"] = "Code block";
            resources["note_quotation"] = "Quotation";
            resources["note_link"] = "Link";
            resources["note_reminder"] = "Reminder...";
            resources["note_header1"] = "Header 1";
            resources["note_header2"] = "Header 2";
            resources["note_header3"] = "Header 3";
            resources["note_pull_from_server"] = "Manually download note";
            resources["note_push_to_server"] = "Manually upload note";
            resources["feedback_note_to_recycle"] = "The note has been moved to the recycle bin and can be restored from there.";

            resources["checklist_create_new"] = "Create new checklist";
            resources["checklist_move_to_top"] = "Move to top";
            resources["checklist_move_up"] = "Move up";
            resources["checklist_move_down"] = "Move down";
            resources["checklist_move_to_bottom"] = "Move to bottom";
            resources["checklist_move_pending_to_top"] = "Move all pending items to top";
            resources["checklist_check_all"] = "Check all (done)";
            resources["checklist_uncheck_all"] = "Uncheck all (pending)";
            resources["checklist_disable_all"] = "Disable all";

            resources["safe_new"] = "Create safe";
            resources["safe_open"] = "Open safe";
            resources["safe_close"] = "Close safe";
            resources["safe_change_password"] = "Change safe password";
            resources["safe_reset"] = "Reset safe";
            resources["safe_confirm_password"] = "Confirm password";
            resources["safe_old_password"] = "Current password";
            resources["safe_new_password"] = "New password";
            resources["safe_add_note"] = "Add note to safe";
            resources["safe_remove_note"] = "Remove note from safe";
            resources["safe_open_existing"] = "Please enter your password, to unlock the protected notes.";
            resources["safe_open_new"] = "Please create a new password to protect your notes. Afterwards you can choose the notes which should be protected.";
            resources["safe_password_requirement"] = "A safe password contains at least 8 characters, it is recommended to use a passphrase like: 'I like to sleep from 10 to august'.";
            resources["safe_reset_warning"] = "If you forgot the password you can reset the safe and create a new one, but thereby you will lose all protected notes. Are you really sure you want to continue?";
            resources["password_short_error"] = "The password needs at least 5 characters.";
            resources["password_confirmation_error"] = "The password confirmation does not match.";
            resources["password_wrong_error"] = "Cannot open the safe with this password, please check for typos.";

            resources["show_recyclebin"] = "Open recycle bin";
            resources["show_settings"] = "Settings";
            resources["empty_recyclebin"] = "Empty recycle bin";
            resources["empty_recyclebin_confirmation"] = "The recycle bin will be cleared. Are you sure you want to continue?";

            resources["show_export"] = "Export notes";
            resources["export_desc"] = "The notes will be exported in the HTML format and therefore keep their formatting. Encrypted notes can only be exported if the safe is open.";
            resources["export_unencrypted"] = "Export unprotected notes";
            resources["export_encrypted"] = "Export decrypted notes from the safe";
            resources["export_success"] = "Successfully exported notes.";
            resources["export_error"] = "Could not export the notes.";

            resources["show_transfer_code"] = "Show transfer code";
            resources["transfer_not_existing"] = "The transfer code will be available after the first synchronization.";
            resources["transfer_code"] = "Transfer code";
            resources["transfer_code_usage"] = "With this transfer code you can decrypt the notes stored in the cloud.";
            resources["transfer_code_required"] = "Please enter the transfer code. You can get the code from an already synchronized device, by using its menu entry «Show transfer code»";
            resources["transfer_code_show_history"] = "Show old transfer codes";
            resources["transfer_code_created"] = "A new transfer code {0} was generated, it can be checked up anytime using the menu ‹Show transfer code›.";
            resources["transfer_code_writedown"] = "We recommend to write the transfercode down, you need it to synchronize the notes with other devices, or when you later have to access the online backup.";

            resources["show_info"] = "Information";
            resources["version"] = "Version";
            resources["copyright"] = "Copyright";
            resources["website"] = "Website";
            resources["opensource"] = "License";
            resources["opensource_desc"] = "SilentNotes is an open source project, published under the terms of the Mozilla Public License v. 2.0.";
            resources["license"] = "SilentNotes respects your privacy, it does not collect user information and requires no unnecessary privileges. The notes never leave the device unencrypted.";
            resources["newer_version"] = "A newer version {0} of SilentNotes available, please install the update.";

            resources["cloud_url"] = "Server directory URL";
            resources["cloud_username"] = "User name";
            resources["cloud_password"] = "Password";
            resources["cloud_secure"] = "Use secure connection (SSL)";
            resources["cloud_service"] = "Online storage";
            resources["cloud_oauth_code"] = "Access code";
            resources["cloud_oauth_code_desc"] = "SilentNotes now opens the web page of the online-storage, please allow access for SilentNotes. Waiting for authorization…";
            resources["cloud_oauth_code_back"] = "Please go back to SilentNotes to continue.";
            resources["cloud_clear_settings"] = "Clear";
            resources["cloud_clear_settings_desc"] = "Removes conection to the online storage";
            resources["cloud_change_settings"] = "Change...";
            resources["cloud_change_settings_desc"] = "Connects to another online storage";
            resources["cloud_first_synchronization_title"] = "Set up the online storage";
            resources["cloud_first_synchronization_text"] = "This is your first synchronization, the necessary information to connect to the online storage is now collected.\nYou can find this information anytime in the menu ‹Settings›";
            resources["cloud_service_choice"] = "Online storage selection";
            resources["cloud_service_credentials"] = "Online storage credentials";
            resources["cloud_service_undefined"] = "No online storage is defined yet";
            resources["cloud_ftp_example"] = "ftp://ftp.example.org/silentnote/";
            resources["cloud_webdav_example"] = "https://webdav.example.org/";

            resources["sync"] = "Synchronization";
            resources["sync_auto"] = "Automatic synchronization";
            resources["sync_auto_never"] = "Never, only manual synchronization";
            resources["sync_auto_costfree"] = "Only if internet is free of cost";
            resources["sync_auto_always"] = "Always";
            resources["sync_notes"] = "Synchronizes notes with the cloud";
            resources["sync_success"] = "Successfully synchronized notes.";
            resources["sync_reject"] = "The synchronization with the cloud was aborted.";
            resources["sync_error_generic"] = "Could not synchronize the notes with the cloud, please try again later.";
            resources["sync_error_transfercode"] = "Please check the transfer code for typos, and use the latest version of SilentNotes.";
            resources["sync_error_connection"] = "Could not connect to the server, please check the internet connection and the server address in the settings.";
            resources["sync_error_privileges"] = "Please check username and password, and make sure you have enough privileges on the server.";
            resources["sync_error_repository"] = "Could not read the notes from the server, because the file has an invalid format.";
            resources["sync_error_revision"] = "Please update SilentNotes, the online-notes are stored in a more recent format.";
            resources["sync_error_oauth_refresh"] = "The online-storage requires a new login, please do once a manual synchronization.";
            resources["sync_repository_merge"] = "Merge notes from local device and server [recommended].";
            resources["sync_repository_cloud"] = "Use notes from the server, delete notes on the local device.";
            resources["sync_repository_device"] = "Use notes from the local device, delete notes on the server.";
            resources["pushpull_pull_confirmation"] = "This local note will be overwritten with the note from the online-storage. Are you sure you want to continue?";
            resources["pushpull_push_confirmation"] = "The note of the online-storage will be overwritten with this locale note. Are you sure you want to continue?";
            resources["pushpull_success"] = "Successfully synchronized this note.";
            resources["pushpull_error_need_sync_first"] = "Could not synchronize this note with the cloud, please do once a manual synchronization of all notes.";
            resources["pushpull_error_no_cloud_note"] = "This note does not exist on the online-storage, please do a synchronization of all notes first.";

            resources["encryption"] = "Encryption";
            resources["encryption_algorithm"] = "Encryption mode";
            resources["encryption_algo_chacha20"] = "ChaCha20-Poly1305 - Modern encryption algorithm [recommended]";
            resources["encryption_algo_aesgcm"] = "AES256-GCM";
            resources["encryption_algo_twofishgcm"] = "Twofish256-GCM";

            resources["gui"] = "User interface";
            resources["gui_font_size"] = "Font size (smaller ‹ normal › larger)";
            resources["gui_note_max_size"] = "Maximum note height (smaller ‹ normal › larger)";
            resources["gui_texture"] = "Theme";
            resources["gui_default_color"] = "Default color for new notes";
            resources["gui_theme_auto"] = "Automatically light or dark mode.";
            resources["gui_theme_dark"] = "Dark mode";
            resources["gui_theme_light"] = "Light mode";
            resources["gui_theme_solid_color"] = "Solid color instead of background image";
            resources["gui_theme_color_all_dark"] = "Same color for all notes in dark mode";
            resources["gui_theme_color_cannot_change"] = "Same color for all notes is set.";
            resources["gui_note_insertion"] = "Placing of new notes";
            resources["gui_note_insertion_top"] = "Insert new notes at the top";
            resources["gui_note_insertion_bottom"] = "Append new notes at the bottom";
        }

        private void LoadGermanResources(Dictionary<string, string> resources)
        {
            resources["ok"] = "OK";
            resources["cancel"] = "Abbrechen";
            resources["back"] = "Zurück";
            resources["continue"] = "Weiter";
            resources["search"] = "Suchen";

            resources["today"] = "heute";
            resources["yesterday"] = "gestern";
            resources["days_ago"] = "vor {0} Tagen";
            resources["weeks_ago"] = "vor {0} Wochen";
            resources["months_ago"] = "vor {0} Monaten";
            resources["years_ago"] = "vor {0} Jahren";
            resources["modified_at"] = "Geändert {0}";

            resources["error_loading_repository"] = "Die Notizen konnten nicht gelesen werden. Die Anwendung wurde gestoppt um bereits existierende Notizen nicht weiter zu beschädigen.";
            resources["welcome_note"] = "<h1>Willkommen 💛</h1><p>SilentNotes respektiert Ihre Privatsphäre, es sammelt keine Benutzerdaten, verzichtet auf Werbung und ist Open Source.";
            resources["welcome_note_2"] = "<h1>Notizen ordnen</h1><p>Ziehen Sie das Doppelpfeil-Icon einer Notiz um die Reihenfolge zu ändern.</p>";
            resources["welcome_note_3"] = "<h1>Passwortschutz</h1><p>Öffnen Sie den Tresor und benützen Sie das Schloss-Icon um eine Notiz zu schützen.</p>";

            resources["note_create_new"] = "Neue Notiz erstellen";
            resources["note_undelete"] = "Notiz wiederherstellen";
            resources["note_title"] = "Titel";
            resources["note_content"] = "Text";
            resources["note_left_key"] = "Linke Pfeiltaste";
            resources["note_right_key"] = "Rechte Pfeiltaste";
            resources["note_colors"] = "Notizfarbe auswählen";
            resources["note_bold"] = "Fett";
            resources["note_italic"] = "Kursiv";
            resources["note_underline"] = "Unterstrichen";
            resources["note_strike"] = "Durchgestrichen";
            resources["note_list_ordered"] = "Nummerierte Liste";
            resources["note_list_unordered"] = "Aufzählungsliste";
            resources["note_code"] = "Code Block";
            resources["note_quotation"] = "Zitat";
            resources["note_link"] = "Link";
            resources["note_header1"] = "Überschrift 1";
            resources["note_header2"] = "Überschrift 2";
            resources["note_header3"] = "Überschrift 3";
            resources["note_pull_from_server"] = "Notiz manuell herunterladen";
            resources["note_push_to_server"] = "Notiz manuell hochladen";
            resources["feedback_note_to_recycle"] = "Die Notiz ist in den Papierkorb verschoben worden und kann von dort wieder hergestellt werden.";

            resources["checklist_create_new"] = "Neue Checkliste erstellen";
            resources["checklist_move_to_top"] = "Schiebe ganz nach oben";
            resources["checklist_move_up"] = "Schiebe nach oben";
            resources["checklist_move_down"] = "Schiebe nach unten";
            resources["checklist_move_to_bottom"] = "Schiebe ganz nach unten";
            resources["checklist_move_pending_to_top"] = "Schiebe unerledigte nach oben";
            resources["checklist_check_all"] = "Setze alle (erledigt)";
            resources["checklist_uncheck_all"] = "Leere alle (unerledigt)";
            resources["checklist_disable_all"] = "Deaktiviere alle";

            resources["safe_new"] = "Tresor einrichten";
            resources["safe_open"] = "Tresor öffnen";
            resources["safe_close"] = "Tresor schliessen";
            resources["safe_change_password"] = "Tresor-Passwort ändern";
            resources["safe_reset"] = "Tresor zurücksetzen";
            resources["safe_confirm_password"] = "Passwort bestätigen";
            resources["safe_old_password"] = "Aktuelles Passwort";
            resources["safe_new_password"] = "Neues Passwort";
            resources["safe_add_note"] = "Notiz zu Tresor hinzufügen";
            resources["safe_remove_note"] = "Notiz aus Tresor herausnehmen";
            resources["safe_open_existing"] = "Bitte geben Sie Ihr Passwort ein, um die geschützten Notizen anzuzeigen.";
            resources["safe_open_new"] = "Bitte vergeben Sie ein neues Passwort um Ihre Notizen zu schützen. Anschliessen können Sie die Notizen auswählen welche geschützt werden sollen.";
            resources["safe_password_requirement"] = "Ein sicheres Passwort enthält mindestens 8 Zeichen, es wird empfohlen einen Passwortsatz zu verwenden wie; 'Ich schlafe gerne von 10 bis August'.";
            resources["safe_reset_warning"] = "Wenn Sie das Passwort vergessen haben können Sie den Tresor zurücksetzen und einen neuen erstellen, aber sämtliche geschützten Notizen gehen dabei verloren. Sind Sie sicher dass Sie weiterfahren wollen?";
            resources["password_short_error"] = "Das Passwort benötigt mindestens 5 Zeichen.";
            resources["password_confirmation_error"] = "Die Passwortbestätigung stimmt nicht überein.";
            resources["password_wrong_error"] = "Kann den Tresor nicht mit diesem Passwort öffnen, bitte achten Sie auf Tippfehler.";

            resources["show_recyclebin"] = "Papierkorb öffnen";
            resources["show_settings"] = "Einstellungen";
            resources["empty_recyclebin"] = "Papierkorb leeren";
            resources["empty_recyclebin_confirmation"] = "Der Papierkorb wird geleert. Sind sie sicher, dass Sie weiterfahren wollen?";

            resources["show_export"] = "Exportiere Notizen";
            resources["export_desc"] = "Die Notizen werden im HTML Format exportiert und behalten so ihre Formatierung bei. Verschlüsselte Notizen können nur exportiert werden, wenn der Tresor offen ist.";
            resources["export_unencrypted"] = "Exportiere ungeschützte Notizen";
            resources["export_encrypted"] = "Exportiere entschlüsselte Notizen aus dem Tresor";
            resources["export_success"] = "Notizen wurden erfolgreich exportiert.";
            resources["export_error"] = "Konnte die Notizen nicht exportieren.";

            resources["show_transfer_code"] = "Transfercode anzeigen";
            resources["transfer_not_existing"] = "Der Transfercode ist erst verfügbar nach der ersten Synchronisation.";
            resources["transfer_code"] = "Transfercode";
            resources["transfer_code_usage"] = "Mit diesem Transfercode können Sie die in der Cloud gespeicherten Notizen entschlüsseln.";
            resources["transfer_code_required"] = "Bitte geben Sie den Transfercode ein. Sie erhalten den Code von einem bereits synchronisierten Gerät, indem sie dort den Menupunkt «Transfercode anzeigen» benutzen.";
            resources["transfer_code_show_history"] = "Ältere Transfercodes anzeigen";
            resources["transfer_code_created"] = "Ein neuer Transfercode {0} wurde generiert, er kann jederzeit im Menu unter ‹Transfercode anzeigen› nachgeschaut werden.";
            resources["transfer_code_writedown"] = "Wir empfehlen den Transfercode aufzuschreiben, Sie benötigen ihn um die Notizen mit anderen Geräten zu synchronisieren, oder wenn Sie später auf das Online Backup zugreifen müssen.";

            resources["show_info"] = "Information";
            resources["version"] = "Version";
            resources["copyright"] = "Copyright";
            resources["website"] = "Webseite";
            resources["opensource"] = "Lizenzierung";
            resources["opensource_desc"] = "SilentNotes ist ein Open Source Projekt, veröffentlicht gemäss den Bedingungen der Mozilla Public License v. 2.0.";
            resources["license"] = "SilentNotes respektiert Ihre Privatsphäre, es sammelt keine Benutzerinformationen und benötigt keine unnötigen Rechte. Die Notizen verlassen das Gerät nie unverschlüsselt.";
            resources["newer_version"] = "Eine neuere Version {0} von SilentNotes ist verfügbar, bitten installieren Sie das Update.";

            resources["cloud_url"] = "Server Verzeichnis URL";
            resources["cloud_username"] = "Benutzername";
            resources["cloud_password"] = "Passwort";
            resources["cloud_secure"] = "Verwende sichere Verbindung (SSL)";
            resources["cloud_service"] = "Online-Speicher";
            resources["cloud_oauth_code"] = "Zugangscode";
            resources["cloud_oauth_code_desc"] = "SilentNotes öffnet nun die Webseite des Online-Speichers, bitte erlauben Sie dort den Zugriff für SilentNotes. Warte auf Erlaubnis…";
            resources["cloud_oauth_code_back"] = "Bitte wechseln Sie nun zurück zu SilentNotes um weiterzufahren.";
            resources["cloud_clear_settings"] = "Entfernen";
            resources["cloud_clear_settings_desc"] = "Entfernt die Verbindung zum Online-Speicher";
            resources["cloud_change_settings"] = "Ändern...";
            resources["cloud_change_settings_desc"] = "Verbindet zu einem anderen Online-Speicher";
            resources["cloud_first_synchronization_title"] = "Einrichten des Online-Speichers";
            resources["cloud_first_synchronization_text"] = "Dies ist die erste Synchronisation, darum werden nun die nötigen Informationen gesammelt, um sich mit dem Online-Speicher zu verbinden.\nDie Informationen finden Sie jederzeit im Menu ‹Einstellungen›.";
            resources["cloud_service_choice"] = "Online-Speicher wählen";
            resources["cloud_service_credentials"] = "Online-Speicher Zugansdaten";
            resources["cloud_service_undefined"] = "Es ist noch kein Online-Speicher bestimmt";
            resources["cloud_ftp_example"] = "ftp://ftp.example.org/silentnote/";
            resources["cloud_webdav_example"] = "https://webdav.example.org/";

            resources["sync"] = "Synchronisation";
            resources["sync_auto"] = "Automatische Synchronisation";
            resources["sync_auto_never"] = "Nie, nur manuell synchronisieren";
            resources["sync_auto_costfree"] = "Nur über kostenfreie Internetverbindung";
            resources["sync_auto_always"] = "Immer";
            resources["sync_notes"] = "Synchronisiert Notizen mit dem Online-Speicher";
            resources["sync_success"] = "Notizen wurden erfolgreich synchronisiert.";
            resources["sync_reject"] = "Die Synchronisation mit dem Online-Speicher wurde abgebrochen.";
            resources["sync_error_generic"] = "Konnte die Notizen nicht mit dem Online-Speicher synchronisieren, bitte versuchen Sie es später nochmals.";
            resources["sync_error_transfercode"] = "Bitten prüfen Sie den Transfercode auf Tippfehler, und benutzen Sie die neueste Version von SilentNotes.";
            resources["sync_error_connection"] = "Konnte nicht zum Online-Speicher verbinden, bitte überprüfen Sie die Internetverbindung und die Server Adresse in den Einstellungen.";
            resources["sync_error_privileges"] = "Bitte überprüfen Sie Benutzername und Passwort, und stellen Sie sicher, dass Sie genügend Rechte auf dem Server besitzen.";
            resources["sync_error_repository"] = "Konnte die Notizen vom Online-Speicher nicht lesen, da die Datei ein ungültiges Format aufweist.";
            resources["sync_error_revision"] = "Bitte aktualisieren Sie SilentNotes, die Online-Notizen sind in einem neueren Format gespeichert.";
            resources["sync_error_oauth_refresh"] = "Der Online-Speicher verlangt eine neue Anmeldung, bitte führen Sie einmalig eine manuelle Synchronisation durch.";
            resources["sync_repository_merge"] = "Zusammenführen der Notizen vom Online-Speicher und vom lokalem Gerät [empfohlen].";
            resources["sync_repository_cloud"] = "Verwende nur Notizen vom Online-Speicher, lösche Notizen auf dem lokalen Gerät.";
            resources["sync_repository_device"] = "Verwende nur Notizen vom lokalen Gerät, lösche Notizen auf dem Online-Speicher.";
            resources["pushpull_pull_confirmation"] = "Diese lokale Notiz wird überschrieben mit der Notiz vom Online-Speicher. Sind sie sicher, dass Sie weiterfahren wollen?";
            resources["pushpull_push_confirmation"] = "Die Notiz vom Online-Speicher wird überschrieben mit dieser lokalen Notiz. Sind sie sicher, dass Sie weiterfahren wollen?";
            resources["pushpull_success"] = "Diese Notiz wurden erfolgreich synchronisiert.";
            resources["pushpull_error_need_sync_first"] = "Konnte diese Notiz nicht mit dem Online-Speicher synchronisieren, bitte führen Sie einmalig eine manuelle Synchronisation aller Notizen durch.";
            resources["pushpull_error_no_cloud_note"] = "Diese Notiz existiert nicht auf dem Online-Speicher, bitte führen Sie vorher eine normale Synchronisation aller Notizen durch.";

            resources["encryption"] = "Verschlüsselung";
            resources["encryption_algorithm"] = "Verschlüsselungsverfahren";
            resources["encryption_algo_chacha20"] = "ChaCha20-Poly1305 - Moderner Algorithmus [empfohlen]";
            resources["encryption_algo_aesgcm"] = "AES-256-GCM";
            resources["encryption_algo_twofishgcm"] = "Twofish-256-GCM";

            resources["gui"] = "Benutzeroberfläche";
            resources["gui_show_arrow_keys"] = "Cursor Pfeiltasten beim Bearbeiten anzeigen";
            resources["gui_font_size"] = "Schriftgrösse (kleiner ‹ normal › grösser)";
            resources["gui_note_max_size"] = "Maximale Notizenhöhe (kleiner ‹ normal › grösser)";
            resources["gui_texture"] = "Design";
            resources["gui_default_color"] = "Standardfarbe für neue Notizen";
            resources["gui_arrow_key"] = "Ein Zeichen nach links/rechts bewegen";
            resources["gui_theme_auto"] = "Automatisch helles oder dunkles Design";
            resources["gui_theme_dark"] = "Dunkles Design";
            resources["gui_theme_light"] = "Helles Design";
            resources["gui_theme_solid_color"] = "Uni Farbe anstatt Hintergrundbild";
            resources["gui_theme_color_all_dark"] = "Gleiche Farbe für alle Notizen in dunklem Design";
            resources["gui_theme_color_cannot_change"] = "Gleiche Farbe für alle Notizen ist eingestellt.";
            resources["gui_note_insertion"] = "Hinzufügen neuer Notizen";
            resources["gui_note_insertion_top"] = "Neue Notiz oben einfügen";
            resources["gui_note_insertion_bottom"] = "Neue Notiz unten anfügen";
        }

        /// <inheritdoc/>
        protected override void LoadTextResources(Dictionary<string, string> textResources, string languageCode)
        {
#if (LANG_EN && DEBUG)
            languageCode = "en";
#elif (LANG_DE && DEBUG)
            languageCode = "de";
#endif

            switch (languageCode.ToLowerInvariant())
            {
                case "de":
                    LoadGermanResources(textResources);
                    break;
                default:
                    LoadEnglishResources(textResources);
                    break;
            }
        }
    }
}
