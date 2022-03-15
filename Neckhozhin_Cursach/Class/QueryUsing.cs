using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckhozhin_Cursach.Class
{
    public static class QueryUsing
    {
        //public static string selectEmployers = "use Perfomance_Artist " +
        //    "select " +
        //    "Employers.Surname_E as 'Фамилия', " +
        //    "Employers.Name_E as 'Имя', " +
        //    "Employers.Patronymic_e as 'Отчество', " +
        //    "Positions.Name_P as 'Должность' " +
        //    "from Employers " +
        //    "inner join Positions on Positions.id_P = Employers.Position_E";
        //public static string selectOrders = "use Perfomance_Artist " +
        //    "select " +
        //    "Work_Shift.Date_WS as 'Дата', " +
        //    "Product.Name_P as 'Продукция',  " +            
        //    "Paint.Name_Color_P as 'Цвет', " +
        //    "Order_.Amount_Product as 'Количество'," +
        //    "Order_.Total_Area as 'Общая Квадратура'," +
        //    "Employers.Surname_E as 'Мастер' " +
        //    "from Order_ " +
        //    "inner join Product on Product.id_P = Order_.Product " +
        //    "inner join Paint on Paint.id_P = Order_.Paint " +
        //    "inner join Master_ on Master_.id_M = Order_.Master_ " +
        //    "inner join Employers on Employers.id_E = Master_.id_E " +
        //    "inner join OrderbyShift on Order_.id_O = OrderbyShift.id_O " +
        //    "inner join Work_Shift on OrderbyShift.id_WS = Work_Shift.id_WS";
        public static string insertEmployer = "use Perfomance_Artist " +
            "insert into Employers(Surname_E, " +
            "Name_E, " +
            "Patronymic_e, " +
            "Position_E) " +
            "values(@Surname_E, " +
            "@Name_E, " +
            "@Patronymic_e, " +
            "@Position_E)";
    }
}