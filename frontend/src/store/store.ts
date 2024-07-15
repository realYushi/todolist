import { configureStore } from "@reduxjs/toolkit";
import taskreducers from "@store/task/taskSlice";
export const store = configureStore({
  reducer: {
    taskreducers: taskreducers,
  },
});
export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
