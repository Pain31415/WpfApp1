using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;

namespace WpfApp1
{
    public partial class CV : Window
    {
        public CV()
        {
            InitializeComponent();
        }

        private void OnEducationButtonClick(object sender, RoutedEventArgs e)
        {
            ShowEducationMessage();
        }

        private void OnWorkExperienceButtonClick(object sender, RoutedEventArgs e)
        {
            ShowWorkExperienceMessage();
        }

        private void OnSkillButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string language = (button.Content as TextBlock)?.Text;

            if (language != null)
            {
                int proficiency = GetLanguageProficiency(language);
                ShowLanguageMessage(language, proficiency.ToString());
            }
        }

        private void ShowLanguageMessage(string language, string proficiency)
        {
            languageMessageText.Text = $"Ця мова вивчена на {proficiency}%.";
            languageMessagePanel.Visibility = Visibility.Visible;
        }

        private void ShowEducationMessage()
        {
            MessageBox.Show("Закінчив університет ВНАУ та магістра, зараз навчаюсь в IT Step Academy.");
        }

        private void ShowWorkExperienceMessage()
        {
            MessageBox.Show("Працюю на TIRAS - 12.");
        }

        private int GetLanguageProficiency(string language)
        {
            switch (language)
            {
                case "C++":
                    return 90;
                case "C#":
                    return 50;
                case "CSS":
                case "HTML":
                    return 70;
                case "Figma":
                    return 40;
                case "Python":
                    return 48;
                default:
                    return 0;
            }
        }
    }
}