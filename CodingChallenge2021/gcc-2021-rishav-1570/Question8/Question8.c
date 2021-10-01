#include <stdio.h>

void calculateMaximizedReturns(int, int, int, int, int[]);

int main()
{
    int n, k, d, m;
    int returns[5000];
    sum=0;
    scanf("%d %d %d %d", &n, &k, &d, &m);
    for(int i=0; i<n; i++)
        scanf("%d", &returns[i]);
    int maximizedReturns = calculateMaximizedReturns(n, k, d, m, returns);
    //do not remove the following line
    printf("%lld", maximizedReturns);
    return 0;
}

int  calculateMaximizedReturns(int n, int k, int d, int m, int returns[])
{
    // Complete the calculateMaximizedReturns function.
    return -1;
}