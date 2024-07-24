using System.Diagnostics;
using System.Xml.Linq;

namespace Week4Exam
{
    public partial class Form1 : Form
    {
        private string _resultInSentence;
        private XDocument _myDoc;
        private string _path = "dates.xml";
        public Form1()
        {
            InitializeComponent();
            initComboBoxes();
            EnsureFile();
            _myDoc = XDocument.Load(_path);
        }

        private void EnsureFile()
        {
            if (!File.Exists(_path))
            {
                XDocument doc = new XDocument(new XElement("Queries"));
                doc.Save(_path);
            }
        }

        private void initComboBoxes()
        {
            List<string> daysOfWeek = new List<string>()
            { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" };
            comboBox_daysOfWeek.DataSource = daysOfWeek;

            comboBox_daysOfMonth.DataSource = Enumerable.Range(1, 30).ToList();

            List<string> months = new List<string>()
            { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" };
            comboBox_month.DataSource = months;

            List<string> years = new List<string>()
            { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" };
            comboBox_year.DataSource = years;
        }

        private void resultInSentence(string weekDay, string monthDay, string month, string year)
        {
            string dayOfWeek;
            string dayOfMonth;
            string myYear;
            switch (weekDay)
            {
                case "ראשון":
                    dayOfWeek = "באחד בשבת";
                    break;
                case "שני":
                    dayOfWeek = "בשני בשבת";
                    break;
                case "שלישי":
                    dayOfWeek = "בשלישי בשבת";
                    break;
                case "רביעי":
                    dayOfWeek = "ברביעי בשבת";
                    break;
                case "חמישי":
                    dayOfWeek = "בחמישי בשבת";
                    break;
                case "ששי":
                    dayOfWeek = "בששי בשבת";
                    break;
                default:
                    MessageBox.Show("no day in week");
                    dayOfWeek = "nothing";
                    break;
            }

            switch (monthDay)
            {
                case "1":
                    dayOfMonth = "יום אחד לירח";
                    break;
                case "2":
                    dayOfMonth = "שני ימים לירח";
                    break;
                case "3":
                    dayOfMonth = "שלשה ימים לירח";
                    break;
                case "4":
                    dayOfMonth = "ארבעה ימים לירח";
                    break;
                case "5":
                    dayOfMonth = "חמשה ימים לירח";
                    break;
                case "6":
                    dayOfMonth = "ששה ימים לירח";
                    break;
                case "7":
                    dayOfMonth = "שבעה ימים לירח";
                    break;
                case "8":
                    dayOfMonth = "שמנה ימים לירח";
                    break;
                case "9":
                    dayOfMonth = "תשעה ימים לירח";
                    break;
                case "10":
                    dayOfMonth = "עשרה ימים לירח";
                    break;
                case "11":
                    dayOfMonth = "אחד עשר ימים לירח";
                    break;
                case "12":
                    dayOfMonth = "שנים עשר ימים לירח";
                    break;
                case "13":
                    dayOfMonth = "שלשה עשר ימים לירח";
                    break;
                case "14":
                    dayOfMonth = "ארבעה עשר ימים לירח";
                    break;
                case "15":
                    dayOfMonth = "חמשה עשר ימים לירח";
                    break;
                case "16":
                    dayOfMonth = "ששה עשר ימים לירח";
                    break;
                case "17":
                    dayOfMonth = "שבעה עשר ימים לירח";
                    break;
                case "18":
                    dayOfMonth = "שמנה עשר ימים לירח";
                    break;
                case "19":
                    dayOfMonth = "תשעה עשר ימים לירח";
                    break;
                case "20":
                    dayOfMonth = "עשרים ימים לירח";
                    break;
                case "21":
                    dayOfMonth = "אחד ועשרים ימים לירח";
                    break;
                case "22":
                    dayOfMonth = "שנים ועשרים ימים לירח";
                    break;
                case "23":
                    dayOfMonth = "שלשה ועשרים ימים לירח";
                    break;
                case "24":
                    dayOfMonth = "ארבעה ועשרים ימים לירח";
                    break;
                case "25":
                    dayOfMonth = "חמשה ועשרים ימים לירח";
                    break;
                case "26":
                    dayOfMonth = "ששה ועשרים ימים לירח";
                    break;
                case "27":
                    dayOfMonth = "שבעה ועשרים ימים לירח";
                    break;
                case "28":
                    dayOfMonth = "שמנה ועשרים ימים לירח";
                    break;
                case "29":
                    dayOfMonth = "תשעה ועשרים ימים לירח";
                    break;
                case "30":
                    dayOfMonth = "יום שלשים לחדש";
                    break;
                default:
                    MessageBox.Show("no day in month");
                    dayOfMonth = "nothing";
                    break;
            }

            switch (year)
            {
                case "תשפ\"ד":
                    myYear = "שנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם";
                    break;
                case "תשפ\"ה":
                    myYear = "שנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם";
                    break;
                case "תשפ\"ו":
                    myYear = "שנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם";
                    break;
                case "תשפ\"ז":
                    myYear = "שנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם";
                    break;
                case "תשפ\"ח":
                    myYear = "שנת חמשת אלפים ושבע מאות ושמנים ושמנה לבריאת העולם";
                    break;
                case "תשפ\"ט":
                    myYear = "שנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם";
                    break;
                case "תש\"צ":
                    myYear = "שנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם";
                    break;
                case "תשצ\"א":
                    myYear = "שנת חמשת אלפים ושבע מאות ותשעים ואחד לבריאת העולם";
                    break;
                case "תשצ\"ב":
                    myYear = "שנת חמשת אלפים ושבע מאות ותשעים ושתים לבריאת העולם";
                    break;
                case "תשצ\"ג":
                    myYear = "שנת חמשת אלפים ושבע מאות ותשעים ושלש לבריאת העולם";
                    break;
                default:
                    MessageBox.Show("no year");
                    myYear = "nothing";
                    break;
            }

            if(monthDay == "30")
            {
                string next = Next(dayOfMonth);
                _resultInSentence = $"{dayOfWeek} {dayOfMonth} {month} שהוא ראש חודש {next} {myYear}";
            }
            else
            {
                _resultInSentence = $"{dayOfWeek} {dayOfMonth} {month} {myYear}";
            }
        }

        private string Next(string current)
        {
            string nextMonth = "";
            if (current == "שבט")
            {
                nextMonth = "אדר";
            }
            else if (current == "אדר" || current == "אדר השני")
            {
                nextMonth = "ניסן";
            }
            else
            {
                nextMonth = comboBox_month.Items[comboBox_month.SelectedIndex+1].ToString();
            }
            return nextMonth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dayOfWeek = comboBox_daysOfWeek.Text;
            string dayOfMonth = comboBox_daysOfMonth.Text;  
            string month = comboBox_month.Text;
            string year = comboBox_year.Text;

            if (string.IsNullOrEmpty(dayOfWeek) || string.IsNullOrEmpty(dayOfMonth) 
                || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(year))
            {
                MessageBox.Show("you have to select all details");
                return;
            }

            resultInSentence(dayOfWeek, dayOfMonth, month, year);

            MessageBox.Show(_resultInSentence);

            XElement dayName = new XElement("Day", dayOfWeek);
            XElement dayMonth = new XElement("DayMonth", dayOfMonth);
            XElement Month = new XElement("Month", month);
            XElement Year = new XElement("Year", year);
            XElement result = new XElement("Result", _resultInSentence);

            XElement query = new XElement("Query", dayName, dayMonth, Month, Year, result);

            XElement root = _myDoc.Root;
            root.Add(query);
            _myDoc.Save(_path);
            return;
        }
    }
}
