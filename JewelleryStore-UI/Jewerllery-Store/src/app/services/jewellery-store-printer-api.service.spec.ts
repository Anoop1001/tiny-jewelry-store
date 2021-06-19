import { TestBed } from '@angular/core/testing';

import { JewelleryStorePrinterApiService } from './jewellery-store-printer-api.service';

describe('JewelleryStorePrinterApiService', () => {
  let service: JewelleryStorePrinterApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JewelleryStorePrinterApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
