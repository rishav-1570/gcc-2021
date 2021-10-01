#include <stdio.h>
int totalPairs(int n, int values[]){
    // Complete the total Pairs function
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
	answer = totalPairs(n, values);
    // Do not remove below line
    printf("%d",answer);
    // Do not print anything after this line
    return 0;
}
