using Eighth_lesson.Shapes;
using Eighth_lesson.Store;

namespace Eighth_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //HomeWork

            //Основное задание

            //1.Написать иерархию классов «Фигуры».
            //Фигура->Треугольник->Прямоугольник->Круг.
            //Реализовать ф-ю подсчета площади для каждого типа фигуры и подсчет периметра.
            //Создать массив из 5 фигур.
            //Вывести на экран сумму периметра всех фигур в массиве.

            //Triangle triangle = new Triangle(5,5);
            //triangle.AreaСalculation();
            //triangle.PerimeterCalculation();

            //Rectangle rectangle = new Rectangle(1,4);
            //rectangle.AreaСalculation();
            //rectangle.PerimeterCalculation();

            //Circle circle = new Circle();
            //circle.AreaСalculation();


            //Shape[] shapes = new Shape[5];
            //shapes[0] = new Triangle(5, 5);
            //shapes[1] = new Rectangle(1, 4);
            //shapes[2] = new Circle(1);
            //shapes[3] = new Triangle(1, 4);
            //shapes[4] = new Rectangle(1, 4);


            //double sum = 0;
            //foreach (Shape shape in shapes)
            //{
            //    sum += shape.PerimeterCalculation();
            //}

            //Console.WriteLine(sum);


            //  Задание 2.
            //  Полную структуру классов и их взаимосвязь продумать самостоятельно.
            //  Исходные данные база(массив) из n товаров задать непосредственно в коде(захардкодить).
            //  Создать базовый класс Product с методами, позволяющим вывести на экран информацию
            //  о товаре, а также определить, соответствует ли она сроку годности на текущую дату.

            //  Создать производные классы:
            //            Продукт(название, цена, дата производства, срок годности),
            //Партия(название, цена, количество шт, дата производства, срок годности), Комплект
            //(названия, цена, перечень продуктов) со своими методами вывода информации на экран,
            //и определения соответствия сроку годности.
            //Создать базу(массив) из n товаров, вывести полную информацию из базы на экран, а
            //также организовать поиск просроченного товара(на момент текущей даты).



            Product[] product =
            [
                new Product("Молоко", 5.5, "15.06.2023", "15.06.2023-15.07.2024"),
                new Product("Хлеб", 6.6, "12.12.2022", "12.12.2022-20.12.2024"),
                new Product("Яйца", 7.7, "01.05.2022", "01.05.2022-01.05.2024"),
                new Product("Мясо", 8.8, "10.09.2023", "10.09.2023-15.09.2024"),
                new Product("Сыр", 9.9, "03.08.2023", "03.08.2023-10.08.2024"),
            ];

            //Сonsignment[] сonsignment =
            //    [
            //        new Сonsignment("Партия Молока", 66.66, 15, "15.06.2022", "15.06.2022-15.03.2024")
            //    ];

            //сonsignment[0].InfoFor();
            //сonsignment[0].ExpirationDate();

            Set set = new Set("МЕГА СЕТ ПРОДУКТОВ ",99.99, product);
            set.InfoFor();
            set.ExpirationDate();
        }
    }
}
