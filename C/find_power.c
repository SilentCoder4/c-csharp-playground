#include <stdio.h>

int main() {
    int num, power, result = 1;

    printf("Enter base number: ");
    scanf("%d", &num);

    printf("Enter power: ");
    scanf("%d", &power);

    for (int i = 1; i <= power; i++) {
        result *= num;
    }

    printf("Result = %d\n", result);

    return 0;
}