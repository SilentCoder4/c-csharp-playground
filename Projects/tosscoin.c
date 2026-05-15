#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int player, computer;

    srand(time(0));

    printf("=== Coin Toss Game ===\n");
    printf("Choose:\n1. Heads\n2. Tails\n");
    printf("Enter your choice: ");
    scanf("%d", &player);

    computer = rand() % 2 + 1;

    if (computer == 1)
        printf("Result: Heads\n");
    else
        printf("Result: Tails\n");

    if (player == computer)
        printf("You Win!\n");
    else
        printf("You Lose!\n");

    return 0;
}