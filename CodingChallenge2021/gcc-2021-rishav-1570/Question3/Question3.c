#include <assert.h>
#include <ctype.h>
#include <limits.h>
#include <math.h>
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int profit_maxi(int maxSum, int* a, int* b) {

}

int main()
{
    int n, m, x, i, result;
    scanf("%d %d %d", &n, &m, &x);

    int a[n], b[m];
    for (i = 0; i < n; ++i) {
        scanf("%d", &a[i]);
    }

    for (i = 0; i < m; ++i) {
        scanf("%d", &b[i]);
    }

    result = profit_maxi(x, a, b);

    printf("%d", result);
    return 0;
}