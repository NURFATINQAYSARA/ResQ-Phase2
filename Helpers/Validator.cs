using System.Text.RegularExpressions;

namespace ResQ
{
    // All input checks live here so every screen uses the same rules.
    // Each Validate method returns null when everything is fine, otherwise the message to show.
    internal static partial class Validator
    {
        public static bool IsBlank(string? text) => string.IsNullOrWhiteSpace(text);

        // Letters, spaces and the usual name marks. 2 to 60 characters, must start with a letter.
        public static bool IsValidFullName(string name) =>
            Regex.IsMatch(name.Trim(), @"^[\p{L}][\p{L}\s'.\-/@]{1,59}$");

        public static bool IsValidUsername(string username) =>
            Regex.IsMatch(username, @"^[A-Za-z0-9_]{3,20}$");

        // Malaysian numbers: mobile 01x-xxxxxxx(x) or landline 0x-xxxxxxx(x). Spaces, dashes and +60 are accepted.
        public static bool IsValidPhone(string phone)
        {
            string digits = Regex.Replace(phone, @"[\s\-\+\(\)]", "");
            return Regex.IsMatch(digits, @"^(0|60)(1\d{8,9}|[3-9]\d{7,8})$");
        }

        // The directory also holds short emergency numbers such as 999, 994 and 112.
        public static bool IsValidDirectoryPhone(string phone) =>
            Regex.IsMatch(phone.Trim(), @"^(999|994|991|112)$") || IsValidPhone(phone);

        public static bool IsValidPassword(string password) => password.Length >= 6;

        public static bool TryParsePositiveInt(string? text, out int value) =>
            int.TryParse(text?.Trim(), out value) && value >= 1;

        public static string? ValidateRegistration(string fullName, string username, string phone, string area,
            string password, string confirm, string? role, string? status)
        {
            if (IsBlank(fullName) || IsBlank(username) || IsBlank(phone) || IsBlank(area) ||
                IsBlank(password) || IsBlank(confirm))
                return "Fill in every field.";

            if (role != "Resident" && role != "Volunteer")
                return "Choose whether you are a Resident or a Volunteer.";

            if (role == "Resident" && status != "Standard" && status != "Needs Support")
                return "Choose your resident status.";

            if (!IsValidFullName(fullName))
                return "Enter your name using letters only (2 to 60 characters).";

            if (!IsValidUsername(username.Trim()))
                return "Username must be 3 to 20 letters, numbers or underscores.";

            if (!IsValidPhone(phone))
                return "Enter a valid phone number, for example 012-3456789.";

            if (area.Trim().Length > 60)
                return "Area must be 60 characters or fewer.";

            if (!IsValidPassword(password))
                return "Password must be at least 6 characters.";

            if (password != confirm)
                return "The passwords don't match.";

            return null;
        }
    }
}