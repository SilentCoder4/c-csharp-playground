#include<stdio.h>
int main()
{
    int p,n,a;
    float r,i;
    printf("Enter the Principal: ");
    scanf("%d", &p);
    printf("Enter the time(M): ");
    scanf("%d", &n);
    printf("Enter the Rate of Intrest: ");
    scanf("%f", &r);

    a = (p*n);
    i= (r/100)*a;

    printf("The amount will: %d\n",a);
    printf("The Intrest Amount will be: %f\n", i);
    printf("Total amount will be: %f\n", a+i);

    return 0;
}
