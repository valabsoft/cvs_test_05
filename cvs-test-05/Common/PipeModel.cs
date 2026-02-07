using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvs_test_05.Common
{
    public enum CalculationMode
    {
        /// <summary>
        /// DS - Внешний параметр и толщина стенки
        /// </summary>
        DS = 0,
        /// <summary>
        /// DD - Внешний и внутренний диаметр
        /// </summary>
        DD = 1
    }

    public class PipeModel
    {
        private double _InnerDiameter;
        private double _OuterDiameter;
        private double _Thickness;
        private double _MomentInertia;
        private double _MomentResistance;
        private double _Area;
        /// <summary>
        /// Внутренний диаметр
        /// </summary>
        public double InnerDiameter
        {
            get { return _InnerDiameter; }
            set { _InnerDiameter = value; }
        }
        /// <summary>
        /// Внешний диаметр
        /// </summary>
        public double OuterDiameter
        {
            get { return _OuterDiameter; }
            set { _OuterDiameter = value; }
        }
        /// <summary>
        /// Толщина стенки
        /// </summary>
        public double Thickness
        {
            get { return _Thickness; }
            set { _Thickness = value; }
        }
        /// <summary>
        /// Момент инерции
        /// </summary>
        public double MomentInertia
        {
            get { return _MomentInertia; }
        }
        /// <summary>
        /// Момент сопротивления
        /// </summary>
        public double MomentResistance
        {
            get { return _MomentResistance; }
        }
        /// <summary>
        /// Площадь поперечного сечения
        /// </summary>
        public double Area
        {
            get { return _Area; }
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PipeModel()
        {
            _InnerDiameter = 0.0;
            _OuterDiameter = 0.0;
            _Thickness = 0.0;
            _MomentInertia = 0.0;
            _MomentResistance = 0.0;
            _Area = 0.0;
        }
        /// <summary>
        /// Задание параметров для расчетов
        /// </summary>
        /// <param name="paramFirst">Внешний диаметр</param>
        /// <param name="paramSecond">Толщина стенки или Внутренний диаметр</param>
        /// <param name="mode">Режим расчета: DS - через толщину стенки; DD - через внутренний диаметр</param>
        /// <returns>Код результата:
        /// 0 - Признак успешного выполнения
        /// 1 - Значение первого параметра задано неверно
        /// 2 - Значение второго параметра задано неверно
        /// 3 - Значение первого параметра меньше чем значение второго
        /// -1 - Признак возникновения исключительной ситуации
        /// </returns>
        public int SetCalculationParameters(double paramFirst, double paramSecond, CalculationMode mode = CalculationMode.DS)
        {
            // Проверка значений параметров
            if (paramFirst <= 0)
                return 1; // Возвращаем код ошибки 1
            if (paramSecond <= 0)
                return 2; // Возвращаем код ошибки 2
            if (paramFirst <= paramSecond)
                return 3; // Возвращаем код ошибки 3
            // Уставка параметров
            try
            {
                switch (mode)
                {
                    case CalculationMode.DS:                        
                        // Задание параметров
                        _OuterDiameter = paramFirst;
                        _Thickness = paramSecond;
                        _InnerDiameter = _OuterDiameter - 2.0 * _Thickness;
                        break;
                    case CalculationMode.DD:
                        // Задание параметров
                        _OuterDiameter = paramFirst;
                        _InnerDiameter = paramSecond;
                        _Thickness = (_OuterDiameter - _InnerDiameter) / 2.0;
                        break;
                    default:
                        // Задание параметров
                        _OuterDiameter = paramFirst;
                        _Thickness = paramSecond;
                        _InnerDiameter = _OuterDiameter - 2.0 * _Thickness;
                        break;
                }
                // Возвращаем признак удачного расчета
                return 0;
            }
            catch
            {
                // Признак исключения при расчетах
                return -1;
            }
        }
        /// <summary>
        /// Расчет характеристик
        /// </summary>
        /// <returns>Код результата:
        /// 0 - - Признак успешного выполнения
        /// -1 - Признак возникновения исключительной ситуации
        /// </returns>
        public int Calculate()
        {
            try
            {
                // Площадь поперечного сечения
                _Area = Math.PI * (Math.Pow(OuterDiameter, 2.0) - Math.Pow(InnerDiameter, 2.0)) / 4.0;
                // Момент инерции
                _MomentInertia = Math.PI * (Math.Pow(OuterDiameter, 4.0) - Math.Pow(InnerDiameter, 4.0)) / 64.0;
                // Момент сопротивления
                _MomentResistance = 2 * _MomentInertia / OuterDiameter;
                // Возвращаем признак удачного расчета
                return 0;
            }
            catch
            {
                // Признак исключения при расчетах
                return -1;
            }
        }
    }
}
