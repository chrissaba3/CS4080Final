import random
import time

n = 2 #starting matrix size
stop = 0 #initialized value for stop timer
start = 0 #initialized value for start timer

while stop - start <= 600: #if a matrix multiplication takes longer than 10 minutes
    start = time.perf_counter() #start timer

    X = [[random.randint(0,10) for i in range(n)] for j in range(n)] #create a 2d array with random numbers

    Y = [[random.randint(0,10) for i in range(n)] for j in range(n)]

    result = [[0 for x in range(n)] for y in range(n)]                  

    for i in range(len(X)):
       for j in range(len(Y[0])):
           for k in range(len(Y)):
                result[i][j] += X[i][k] * Y[k][j]       #multiply the X and Y matrices into the resultant matrix 

    stop = time.perf_counter()  #stop timer

   # if n < 5:
   #    print("X matrix:")  this is if you want to display the matrices to show values. If you wish
   #    for x in X:         to view this just uncomment and change the if statement to however many
   #         print(x)       matrices you wish to see
   #     print("Y matrix:")
   #     for y in Y:
   #         print(y)
   #     print("Result matrix:")
   #     for r in result:
   #         print(r)

    print("Duration for ", n , " x " , n ," is: ", stop-start) #display the time it took to complete the multiplication

    n *= 2  #increase the size of the array by doubling

print("next matrix took too long. Exceeds 10 mins.")    #display that the next matrix that would be calculated would take longer than 10 minutes. ends code