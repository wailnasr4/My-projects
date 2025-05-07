#include <iostream>
#include <vector>
#include <stdlib.h>
#include <time.h>
using namespace std;

const int BOARD_SIZE = 5;
const char COLORS[] = {'R', 'G', 'B', 'Y'};
const int MIN_BLOCKS_TO_BLAST = 3;

// توليد كتل ملونة عشوائية
char generateRandomColor() {
    return COLORS[rand() % 4];
}

// إنشاء لوحة اللعب
vector<vector<char>> createBoard() {
    vector<vector<char>> board(BOARD_SIZE, vector<char>(BOARD_SIZE));
    for (int i = 0; i < BOARD_SIZE; i++) {
        for (int j = 0; j < BOARD_SIZE; j++) {
            board[i][j] = generateRandomColor();
        }
    }
    return board;
}

// طباعة لوحة اللعب
void printBoard(const vector<vector<char>>& board) {
    for (int i = 0; i < BOARD_SIZE; i++) {
        for (int j = 0; j < BOARD_SIZE; j++) {
            cout << board[i][j] << " ";
        }
        cout << endl;
    }
}

// تفجير الكتل المتشابهة
void blastBlocks(vector<vector<char>>& board, int row, int col, char color) {
    if (row < 0 || row >= BOARD_SIZE || col < 0 || col >= BOARD_SIZE || board[row][col] != color) {
        return;
    }

    board[row][col] = ' '; // تفجير الكتلة

    blastBlocks(board, row + 1, col, color);
    blastBlocks(board, row - 1, col, color);
    blastBlocks(board, row, col + 1, color);
    blastBlocks(board, row, col - 1, color);
}

// تحديث لوحة اللعب بعد تفجير الكتل
void updateBoard(vector<vector<char>>& board) {
    for (int i = BOARD_SIZE - 1; i >= 0; i--) {
        for (int j = 0; j < BOARD_SIZE; j++) {
            if (board[i][j] == ' ') {
                for (int k = i - 1; k >= 0; k--) {
                    if (board[k][j] != ' ') {
                        board[i][j] = board[k][j];
                        board[k][j] = ' ';
                        break;
                    }
                }
            }
        }
    }
}

int main() {
    srand(time(0)); // تهيئة مولد الأرقام العشوائية

    vector<vector<char>> board = createBoard();

    cout << "Welcome to Block Blast!" << endl;
    cout << "Here is the initial board:" << endl;
    printBoard(board);

    int row, col;
    char selectedColor;

    while (true) {
        cout << "Enter row and column to blast (e.g., 1 2): ";
        cin >> row >> col;

        if (row < 1 || row > BOARD_SIZE || col < 1 || col > BOARD_SIZE) {
            cout << "Invalid input. Please try again." << endl;
            continue;
        }

        selectedColor = board[row - 1][col - 1];
        blastBlocks(board, row - 1, col - 1, selectedColor);
        updateBoard(board);

        printBoard(board);

        // فحص نهاية اللعبة
        bool endGame = true;
        for (int i = 0; i < BOARD_SIZE; i++) {
            for (int j = 0; j < BOARD_SIZE; j++) {
                if (board[i][j] != ' ') {
                    endGame = false;
                    break;
                }
            }
        }

        if (endGame) {
            cout << "Game Over! All blocks are cleared." << endl;
            break;
        }
    }

    return 0;
}