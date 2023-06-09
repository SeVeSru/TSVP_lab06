# TSVP_lab06

Данный код реализует алгоритм Флойда для нахождения кратчайших расстояний между всеми парами вершин в заданном графе.

Первая строка объявляет переменную INF и присваивает ей максимальное значение типа int. Это значение будет использоваться для обозначения отсутствия ребра между двумя вершинами в графе.

Далее создается двумерный массив graph, который представляет собой матрицу смежности заданного графа. Значения в матрице обозначают веса ребер между соответствующими вершинами. Если ребра между вершинами нет, то значение равно INF.

Затем создается двумерный массив dist, который инициализируется значениями из матрицы смежности graph. Массив dist будет содержать кратчайшие расстояния между всеми парами вершин в графе.

Далее следует основной этап алгоритма Флойда. Внешний цикл перебирает все вершины графа, второй цикл перебирает все вершины графа для каждой вершины k, а внутренний цикл обновляет значение кратчайшего расстояния между вершинами i и j, если найден путь через вершину k, который короче текущего.

После выполнения алгоритма Флойда массив dist содержит кратчайшие расстояния между всеми парами вершин в графе.

В конце кода происходит вывод матрицы кратчайших расстояний на консоль.

Общий смысл алгоритма заключается в том, что он находит кратчайшие расстояния между всеми парами вершин в графе, используя динамическое программирование.
