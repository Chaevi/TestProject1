﻿namespace TestProject1
{
    public abstract class Figure
    {
        // В задании сказанно чтобы программа умела вычислять площадь
        // Поэтому более никаких данных не добавлял ибо не знаю в каких задачах будет использоваться
        // Все вычисления площади проволятся в конструкторе класса, там же и принимаются данные о сторонах

        protected float Area;

        public float GetArea()
        {
            return Area;
        }
    }
}