using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace SupportDownloader
{
    static class StringExtension
    {
        public static String FormatWith(this String s, params Object[] args)
        {
            return String.Format(s, args);
        }

        public static bool In(this String s, params String[] args)
        {
            return args.Contains(s);
        }

        public static bool ContainSubstr(this String s, params String[] args)
        {
            foreach (var item in args) if (s.IndexOf(item) < 0) return false;
            return true;
        }

        public static bool notnull(this String s)
        {
            return s != null && s.Length > 0;
        }

        public static bool NotIn(this String s, params String[] args)
        {
            return args.Contains(s) == false;
        }

        public static void ShowError(this String s, params String[] args)
        {
            MessageBox.Show(String.Format(s, args), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void ShowInfo(this String s, params String[] args)
        {
            MessageBox.Show(String.Format(s, args), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static bool ShowQuestion(this String s, params String[] args)
        {
            return MessageBox.Show(String.Format(s, args), "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
        }

    }
}
