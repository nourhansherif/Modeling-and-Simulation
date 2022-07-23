# Multi-Channel-Queue-Simulation
A simulation system that simulates the customer's usage of a system having one or more servers to determine whether the system performs well or needs another server to be added.

# System Input:
1) Inter-arrival time distribution
2) Number of servers
3) Service time distribution for each server
4) Server Selection method 
   - Priority.
   - Random.
   - Least Utilization.
5) Stopping Condition 
   - Maximum Number of customers.
   - Simulation end time.

**Note: Assume the order of the servers entered is the order of the priority**

# System Output:
1) Simulation Table that includes: 
   - Customer No
   - Random Digit for inter-arrival time
   - Inter-arrival time
   - Arrival time (Clock Time)
   - Random Digit for service duration
   - Service duration
   - Server Index
   - Time Service Begins 
   - Time Service Ends (Departure)
   - Total delay time for this customer (Time in queue)
 
2) Performance Measures of the System:
   - Average waiting time (in the queue). 
   <!---![image](https://user-images.githubusercontent.com/66736704/159714398-8fab54e7-99bb-4c7a-8166-5ab7775a4431.png)--->
   - Maximum queue length. 
   - Probability that a customer wait in the queue. 
    <!---![image](https://user-images.githubusercontent.com/66736704/159714452-a68a0af7-b11b-4f0e-b302-a3e7225cbf0c.png)--->


4) Performance Measures **Per Server**:
   - Average service time per server. 
   <!---![image](https://user-images.githubusercontent.com/66736704/159714506-b5c92e0b-35c7-4344-a746-61cdc690976d.png)-->
   - Utilization of each server
   <!---![image](https://user-images.githubusercontent.com/66736704/159714533-fa79ab8b-4b12-4ad0-ac1b-8c813262a17a.png)--> 
   - Probability that a server is in idle state.
   <!---![image](https://user-images.githubusercontent.com/66736704/159714477-e94bb690-b6de-4577-9e7b-a32a0be292e7.png)-->




