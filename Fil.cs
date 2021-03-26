using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filosofi
{
    public class Fil
    {
        public
        string name, bio, vis, etik, log, poet, prav;

        public Fil(string ename="",string ebio="",string evis="",string eetik="",string elog="", string epoet="",string eprav="")
        {
            //Конструктор по умолчанию в случае создания класса с уже заполненными данными
            name = ename; bio = ebio;   vis = evis; etik = eetik;
            log = elog;   poet = epoet; prav = eprav;   
        }

        public Fil()//Перегруженный конструктор по умолчанию в случае создания пустого класса, для дальнейшего заполнения
        {
            name = "";  bio = "";   vis = "";    etik = "";
            log = "";   poet = "";  prav = "";
        }

        //Не стал делать данные в классе указателями и последующий деструктор, ибо класс маленький                                                                                                (ну и лень о_О)
    }
}
