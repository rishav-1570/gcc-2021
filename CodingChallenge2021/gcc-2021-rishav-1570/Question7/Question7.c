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

void countStablePartitions(int n, int values[]){
    return -1;
}
int main(){
    int n, i;
    scanf("%d", &n);
    int answer;
    int values[n];
    for (i = 0; i < n; ++i) {
        scanf("%d", &values[i]);
    }
	countStablePartitions(n, values);
    return 0;
}
