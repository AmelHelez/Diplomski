import { Time } from "@angular/common";

export interface Appointment {
  id: number;
  appointmentDate: Date;
  salonId: number;
  employeeId: number;
  userId: number;
  treatmentId: number;
}
