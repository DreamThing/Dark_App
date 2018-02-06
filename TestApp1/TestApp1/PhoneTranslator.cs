using System.Text;
using System;

namespace Core {
    public static class PhonewordTranslator {
        public static string ToNumber(string text) {
            if (string.IsNullOrWhiteSpace(text)) {
                return "";
            }
            else {
                text = text.ToUpperInvariant();
            }

            var newNumber = new StringBuilder();

            foreach (var item in text) {
                if(" -0123456789".Contains(item)) {
                    newNumber.Append(item);
                }
                else {
                    var result = TranslateToNumber(item);
                    if(result != null) {
                        newNumber.Append(result);
                    }
                }
            }
            return newNumber.ToString();
        }

        static bool Contains(this string keyString, char item) {
            return keyString.IndexOf(item) >= 0;
        }

        static int? TranslateToNumber(char item) {
            if ("ABC".Contains(item)) {
                return 2;
            }
            else if ("DEF".Contains(item)) {
                return 3;
            }
            else if ("GHI".Contains(item)) {
                return 4;
            }
            else if ("JKL".Contains(item)) {
                return 5;
            }
            else if ("MNO".Contains(item)) {
                return 6;
            }
            else if ("PQRS".Contains(item)) {
                return 7;
            }
            else if ("TUV".Contains(item)) {
                return 8;
            }
            else if ("WXYZ".Contains(item)) {
                return 9;
            }
            return null;
        }
    }
}
