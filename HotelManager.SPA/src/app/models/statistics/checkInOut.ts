export interface CheckInOutDay {
  value: number;
  name: Date;
}

export interface CheckInOutStatistics {
  name: string;
  series: CheckInOutDay[];
}
