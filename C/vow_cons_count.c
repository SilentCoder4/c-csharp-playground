#include <stdio.h>
#include <string.h>

int main() {
    char text[100];
    int vowels = 0, consonants = 0;

    printf("Enter a string: ");
    fgets(text, sizeof(text), stdin);

    for(int i = 0; text[i] != '\0'; i++) {
        char ch = text[i];

        if(ch >= 'A' && ch <= 'Z')
            ch += 32;

        if((ch >= 'a' && ch <= 'z')) {
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                vowels++;
            else
                consonants++;
        }
    }

    printf("Vowels: %d\n", vowels);
    printf("Consonants: %d\n", consonants);

    return 0;
}