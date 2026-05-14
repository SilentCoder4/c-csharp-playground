#include <stdio.h>

int main() {
    char text[100];
    int frequency[256] = {0};

    printf("Enter a text: ");
    fgets(text, sizeof(text), stdin);

    for (int i = 0; text[i] != '\0'; i++) {
        frequency[(int)text[i]]++;
    }

    printf("\nCharacter Frequencies:\n");

    for (int i = 0; i < 256; i++) {
        if (frequency[i] > 0 && i != '\n') {
            printf("%c = %d\n", i, frequency[i]);
        }
    }

    return 0;
}