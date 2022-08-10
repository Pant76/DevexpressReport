using AutoMapper;
using AutoMapper.QueryableExtensions;
using DevExpress.DataAccess.ObjectBinding;
using System.ComponentModel;

namespace Uell.Web.Reports
{

    [HighlightedClass]
    public class ReportDto
    {


        public ReportDto()
        {
            User = new UserItem()
            {
                FirstName = "Marco",
                LastName = "Meneghini",
                FullName = "Marco Meneghini"
            };
            for (int i = 0; i < 10; i++)
            {
                var ans = new AnswerReportItem()
                {
                    Categoria = "Resistenza",
                    QuestionText = $"Domanda n.{i + 1}",
                    Eseguito = "Si",
                    RespText = "Eccellente",
                    Risultato = 80
                };
               FitnessAnswers.Add(ans);
            }
        }

        public UserItem User { get; set; }
        public List<AnswerReportItem> FitnessAnswers { get; set; } = new List<AnswerReportItem>();

    }

    public class UserItem
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }

    public class AnswerReportItem //: IMapFrom<Answer>
    {
        public int Id { get; set; }
        public int Num { get; set; }
        public string Categoria { get; set; }
        public string QuestionText { get; set; }

        public string RespText { get; set; }
        public string Eseguito { get; set; }
        public int Risultato { get; set; }
    }
}
