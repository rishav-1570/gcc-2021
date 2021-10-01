#include <stdio.h>
int bankersAndClients(int c,int b,int** time){
	// Complete the bankersAndClients function .
    return -1;
}
int main(){
    int b,c;
    scanf("%d %d", &c, &b);
    int answer;
    int** time;
    time = malloc(b * sizeof *time);
    for (int i=0; i<b; i++)
	 {
		time[i] = malloc(c * sizeof *time[i]);
	 }
    for(int i = 0; i < b; i++){
        
        for(int j = 0;j < c;j++){
          scanf("%d",&time[i][j]);
        }
    }
	answer = bankersAndClients(c,b,time);
    // Do not remove below line
    printf("%d",answer);
    // Do not print anything after this line
        
    return 0;
}
