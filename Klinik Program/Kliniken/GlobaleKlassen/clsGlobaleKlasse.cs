using KlinkDatenSchicht;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DatenzugriffExecption : Exception
{
    public DatenzugriffExecption(string message) : base(message) { }
    public DatenzugriffExecption(string message, Exception innermessage) : base(message) { }

}
namespace Kliniken
{
    public class clsGlobaleKlasse
    {
        public static clsBenutzerDaten BenutzerDaten;

        private static readonly string RegistryPath = @"SOFTWARE\MyApp\Security";

        public static bool SaveUsernameAndPasswordInRegistry(string Username, string Password, bool Speichern)
        {
            if (Speichern)
            {
                try
                {
                    using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(RegistryPath))
                    {
                        if (reg != null)
                        {
                            //Alte Werte löschen
                            reg.DeleteValue("Benutzername", false);
                            reg.DeleteValue("Passwort", false);

                            // Speichern Benutzername und Password .
                            reg.SetValue("Benutzername", Username, RegistryValueKind.String);
                            reg.SetValue("Passwort", Password, RegistryValueKind.String);

                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hier sollten Sie Logging oder eine andere Fehlerbehandlung einfügen
                    throw new DatenzugriffExecption($"Fehler beim Speichern von Benutzername und Password in der Registry: {ex.Message}");
                }
            }
            return false;
        }

        public static bool GetUsernameAndPasswordFromRegistry(ref string Username, ref string Password)
        {
            try
            {
                using (RegistryKey reg = Registry.CurrentUser.OpenSubKey(RegistryPath))
                {
                    if (reg != null)
                    {
                        Username = (string)reg.GetValue("Benutzername");
                        Password = (string)reg.GetValue("Passwort");

                        return true;
                    }
                    else
                    {
                        throw new DatenzugriffExecption("Registry-Schlüssel nicht gefunden.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hier sollten wir Logging oder eine andere Fehlerbehandlung einfügen
                throw new DatenzugriffExecption($"Fehler beim Erhalten von Benutzername und Password von der Registry: {ex.Message}");
            }
            return false;
        }
    }
}
