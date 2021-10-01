def BankerAndClients(client, banker, time):
	# Participants code will be here
	return -1

if __name__ == "__main__":
	abc=list(map(int,input().split()))
	client=abc[0]
	banker=abc[1]
	time=[[0 for i in range(20)] for j in range(10)]
	time = [list(map(int, input().split())) for y in range(banker)]
	result = BankerAndClients(client, banker, time)
	# Do not remove below line
	print(result)    
	# Do not print anything after this line# your code goes here
