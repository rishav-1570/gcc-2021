#include <stdio.h>
#include <string.h>
#include <stdlib.h>
char* solution(char* input)
{
    //write code here
    
    //return a string and not a char . Look below template of return.
    //return "A";
    //return "B"
}

int main(void) {

	int max = 100000;
	char *s=(char*)malloc(max*sizeof(char));
	scanf("%s",s);
	char *ans=solution(s);
  printf("%s",ans);
	return 0;
}
