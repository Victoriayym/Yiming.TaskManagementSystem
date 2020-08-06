import { TaskHistory } from './taskHistory';
import { Task } from './task';

export interface AllTask{
    tasks:Task[];
    tasksHistory:TaskHistory[]
}