#include <stdio.h>

struct Bank {
    int accNo;
    char name[50];
    float balance;
};

int main() {
    struct Bank customer;

    printf("Enter Account Number: ");
    scanf("%d", &customer.accNo);

    printf("Enter Name: ");
    scanf("%s", customer.name);

    printf("Enter Balance: ");
    scanf("%f", &customer.balance);

    printf("\n--- Account Details ---\n");
    printf("Account Number: %d\n", customer.accNo);
    printf("Name: %s\n", customer.name);
    printf("Balance: %.2f\n", customer.balance);

    return 0;
}