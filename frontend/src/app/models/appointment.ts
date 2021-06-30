import { Time } from "@angular/common";

export interface Appointment {
  id: number;
  appointmentDate: Date;
  appointmentTime: Time;
  salonId: number;
  employeeId: number;
  userId: number;
  treatmentId: number;
}
