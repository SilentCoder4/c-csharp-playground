#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    char choices[] = {'R', 'P', 'S'};
    char user, computer;

    srand(time(0));

    printf("=== Rock Paper Scissors ===\n");
    printf("Enter R for Rock, P for Paper, S for Scissors: ");
    scanf(" %c", &user);

    computer = choices[rand() % 3];

    printf("Computer chose: %c\n", computer);

    if (user == computer)
        printf("It's a Draw!\n");
    else if (
        (user == 'R' && computer == 'S') ||
        (user == 'P' && computer == 'R') ||
        (user == 'S' && computer == 'P')
    )
        printf("You Win!\n");
    else
        printf("Computer Wins!\n");

    return 0;
}