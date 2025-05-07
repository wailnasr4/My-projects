#include <iostream>
#include <ctime>
#include <stdlib.h>
#include <conio.h>
#include <windows.h>
using namespace std;
void shift(int arr[], int size)
{
    for (int i = size - 2; i >= 0; i--)
        arr[i + 1] = arr[i];
}
enum Dir
{
    Top = 1,
    Donw,
    Right,
    Left
};
struct Map
{
    int width, height, fruitx, fruity;
};
struct Snake
{
    int headx, heady, tail_n, tail_x[50], tail_y[50];
    Dir dit;
};
struct Player
{
    int score;
    bool lose;
};
Map Map1;
Snake Snake1;
Player Player1;
void Generate_fruit()
{
    srand(time(0));
    Map1.fruitx = rand() % (Map1.width - 2) + 1;
    Map1.fruity = rand() % (Map1.height - 2) + 1;
}
void setup()
{
    Map1.width = 40;
    Map1.height = 20;
    Generate_fruit();

    Snake1.headx = Map1.width / 2;
    Snake1.heady = Map1.height / 2;
    Snake1.tail_n = 0;

    Player1.score = 0;
    Player1.lose = false;
}
void drow()
{
    system("cls");
    for (int i = 0; i < Map1.height; i++)
    {
        for (int j = 0; j < Map1.width; j++)
        {
            if (i == 0 || i == Map1.height - 1)
                cout << "*";
            else if (j == 0 || j == Map1.width - 1)
                cout << "*";
            else if (i == Snake1.heady && j == Snake1.headx)
                cout << "0";
            else if (i == Map1.fruity && j == Map1.fruitx)
                cout << "$";
            else
            {
                bool printed = false;
                for (int z = 0; z < Snake1.tail_n; z++)
                {
                    if (Snake1.tail_x[z] == j && Snake1.tail_y[z] == i)
                    {
                        cout << "o";
                        printed = true;
                        break;
                    }
                }
                if (!printed)
                    cout << " ";
            }
        }
        cout << endl;
    }

    cout << "player score :" << Player1.score << endl;
}
void input()
{
    if (_kbhit())
    {
        char c = _getch();
        switch (c)
        {
        case 'w':
            Snake1.dit = Top;
            break;
        case 's':
            Snake1.dit = Donw;
            break;
        case 'd':
            Snake1.dit = Right;
            break;
        case 'a':
            Snake1.dit = Left;
            break;
        case 'x':
            exit(0);
        }
    }
}
void move()
{
    shift(Snake1.tail_x, 50);
    shift(Snake1.tail_y, 50);
    Snake1.tail_x[0] = Snake1.headx;
    Snake1.tail_y[0] = Snake1.heady;
    switch (Snake1.dit)
    {
    case Top:
        Snake1.heady--;
        break;
    case Donw:
        Snake1.heady++;
        break;
    case Right:
        Snake1.headx++;
        break;
    case Left:
        Snake1.headx--;
        break;
    }
    if (Snake1.heady >= Map1.height || Snake1.headx <= 0 || Snake1.headx >= Map1.width || Snake1.headx <= 0)
        Player1.lose = true;
    if (Snake1.headx == Map1.fruitx && Snake1.heady == Map1.fruity)
    {
        Generate_fruit();
        Player1.score += 1;
        Snake1.tail_n++;
    }
}
int main()
{
    setup();
    while (!Player1.lose)
    {
        drow();
        input();
        move();
        Sleep(50);
    }

    return 0;
}
