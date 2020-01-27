import { TestBed } from '@angular/core/testing';

import { CallAzureService } from './call-azure.service';

describe('CallAzureService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CallAzureService = TestBed.get(CallAzureService);
    expect(service).toBeTruthy();
  });
});
