#include <stdio.h>

int main() {
    int choice;
    float num1, num2;

    while (1) {
        printf("\n=== Simple Billing System ===\n");
        printf("1. Add Product\n");
        printf("2. Generate Bill\n");
        printf("3. Exit\n");

        printf("Enter choice: ");
        scanf("%d", &choice);

        switch(choice) {
            case 1:
                printf("Enter product price: ");
                scanf("%f", &num1);

                printf("Enter quantity: ");
                scanf("%f", &num2);

                printf("Total = %.2f\n", num1 * num2);
                break;

            case 2:
                printf("Bill Generated Successfully\n");
                break;

            case 3:
                return 0;

            default:
                printf("Invalid Choice\n");
        }
    }
}